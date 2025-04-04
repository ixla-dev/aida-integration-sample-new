using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using integratorApplication.Backend;
using integratorApplication.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Http.Logging;
using Microsoft.Extensions.Logging;

namespace integratorApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private dbPgManager _dbPgManager;
        private dbSqlLiteManager _dbSqlLiteManager;
        private IntegrationApi _integrationApi;
        private ConnectionStatus _connectionStatus;
        private DataExchangeTableDefinition _detDefinition;
        private DispatcherTimer _pollingTimer;
        private WorkflowSchedulerStateDto _workflowSchedulerStateDto;
        private List<DataRecordField> _dataRecordFields;
        private List<EntityDescriptor> _entityDescriptors;
        private JobTemplateDto _selectedJobTemplateDto;
        private DataTable _dataTable;
        private readonly IServiceProvider _serviceProvider;
        private IHost _webHost;
        private WorkflowSchedulerStatus _jobStatus;
        private WorkflowSchedulerStopReason _JobStopReason;
        private CancellationTokenSource _cancellationTokenSource;
        private readonly WebhooksHandler _webhooksHandler;
        public MainWindow()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
            
            _dataTable = new DataTable();
            
            
            var handler = _serviceProvider.GetRequiredService<WebhooksHandler>();
            handler.MessageReceived += (_, e) =>
            {
                Debug.WriteLine("message received");
                OpenMessageDialog(e);

            };
            
            
            _webhooksHandler = handler;
            // Configura e avvia l'host web
            _webHost = CreateHostBuilder().Build();
            _webHost.Start();
            
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<WebhooksHandler>();
            services.AddLogging(configure => configure.AddConsole());
        }
        public IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices(services =>
                    {
                        services.AddHttpLogging(logging =>
                        {
                            logging.LoggingFields = HttpLoggingFields.All;
                            logging.RequestHeaders.Add("sec-ch-ua");
                            logging.ResponseHeaders.Add("MyResponseHeader");
                            logging.MediaTypeOptions.AddText("application/javascript");
                            logging.RequestBodyLogLimit = 4096;
                            logging.ResponseBodyLogLimit = 4096;
                            logging.CombineLogs = true;

                        });
                        services.AddControllers();
                        services.AddSingleton(_ => _webhooksHandler);
                        services.AddSingleton(new JsonSerializerOptions
                        {
                            Converters = { new JsonStringEnumConverter() },
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                        });
                    });

                    webBuilder.Configure(app =>
                    {
                        var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
                        if (env.IsDevelopment())
                        {
                            app.UseDeveloperExceptionPage();
                        }

                        app.UseStaticFiles();
                        app.UseHttpLogging(); 
                        app.Use(async (context, next) =>
                        {
                            context.Response.Headers["MyResponseHeader"] =
                                new string[] { "My Response Header Value" };

                            await next();
                        });                        
                        app.UseRouting();
                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                        });
                    });

                    webBuilder.UseUrls("http://0.0.0.0:8765");
                });
        
        public enum ConnectionStatus
        {
            Disconnected,
            Connecting,
            Connected
        }
        
        public enum MachineStatus
        {
            feederEmpty
        }

private async void ConnectBtn_Click(object sender, RoutedEventArgs e)
{
    MachineAddress.IsEnabled = false;
    ConnectBtn.IsEnabled = false;
    bool isConnected = false; 
    
    _cancellationTokenSource = new CancellationTokenSource();
    
    try
    {
        ConnectBtn.IsEnabled = false;
        
        string BASE_PATH = $"http://{MachineAddress.Text}:5000";
        _integrationApi = new IntegrationApi(BASE_PATH);
        _dbPgManager = new dbPgManager();
        _dbSqlLiteManager = new dbSqlLiteManager();

        // API Connection
        try
        {
            var wfState = await _integrationApi.GetWorkflowSchedulerStateAsync();
            if (wfState != null)
            {
                _connectionStatus = ConnectionStatus.Connected;
                isConnected = true;
                GetJoblist();
                _ = MonitorConnectionAsync();            }
            else
            {
                MessageBox.Show("Incorrect Machine Address", "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show($"Connection to Machine failed: {ex.Message}", "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        // SQLite Connection
        try
        {
            _dbSqlLiteManager.DbSqlLiteConnect();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"SQLite connection failed: {ex.Message}", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        // PostgreSQL Connection
        try
        {
            bool isPgConnected = _dbPgManager.DbPgConnect(MachineAddress.Text);
            if (!isPgConnected)
            {
                MessageBox.Show("Failed to connect to Aida DB.", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"PostgreSQL connection failed: {ex.Message}", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }
    finally
    {
        ConnectBtn.IsEnabled = !isConnected;
        MachineAddress.IsEnabled = !isConnected;
    }
}

private async Task MonitorConnectionAsync()
{
    try
    {
        while (!_cancellationTokenSource.Token.IsCancellationRequested)
        {
            try
            {
                var wfState = await _integrationApi.GetWorkflowSchedulerStateAsync().ConfigureAwait(false);
                if (wfState == null)
                {
                    throw new Exception("Lost connection to machine.");
                }
                
                _connectionStatus = ConnectionStatus.Connected;
                
                // Update the UI
                Application.Current.Dispatcher.Invoke(UpdateUI);

                // Load data 
                Application.Current.Dispatcher.Invoke(LoadData);
                    
                _jobStatus = wfState.Status ?? WorkflowSchedulerStatus.Stopped;
                _JobStopReason = wfState.StopReason ?? WorkflowSchedulerStopReason.ManualStop;

                // Update UI controls
                Application.Current.Dispatcher.Invoke(() =>
                {
                    StatusTextBlock.Text = $"Status: {_jobStatus}";
                    StopReasonTextBlock.Text = $"Stop Reason: {_JobStopReason}";
                    ProgressBar.IsIndeterminate = (_jobStatus == WorkflowSchedulerStatus.Running ||
                                                   _jobStatus == WorkflowSchedulerStatus.Starting ||
                                                   _jobStatus == WorkflowSchedulerStatus.Waiting);
                });
                
                await Task.Delay(2000,_cancellationTokenSource.Token);
            }
            catch (HttpRequestException ex)
            {
                _connectionStatus = ConnectionStatus.Disconnected;
                Application.Current.Dispatcher.Invoke(UpdateUI);
                MessageBox.Show($"Connection lost: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                break;
            }
        }
    }
    finally
    {
        _cancellationTokenSource.Dispose();
    }
}


        private void OpenMessageDialog(WorkflowMessage e)
        {
            if (e.ErrorCode != null && e.ErrorCode != JobErrorCodes.NoErrors)
            {
                string? errorMessage = Enum.GetName(typeof(JobErrorCodes), e.ErrorCode);

                Application.Current.Dispatcher.Invoke(() =>
                {
                    MessageSnackbar.IsActive = true;
                    SnackbarText.Content = errorMessage;
                    Task.Delay(5000);
                    MessageSnackbar.IsActive = false;
                });
                Console.WriteLine($"Webhooks ---> {errorMessage}");
            }
            if (e.MessageType == MessageType.EncoderLoaded)
            {
                EncodingTimer(e);
            } 
        }

        private async void EncodingTimer(WorkflowMessage e)
        {
            
            Application.Current.Dispatcher.Invoke(() =>
            {
                MessageSnackbar.IsActive = true;
                SnackbarText.Content = $"Encoding...";
            });
            //await Task.Delay(2000);
            _integrationApi.SignalExternalProcessCompletedAsync(false,
                new ExternalProcessCompletedMessage
                {
                    Outcome = ExternalProcessOutcome.Completed,
                    WorkflowInstanceId = e.WorkflowInstanceId
                });
            Application.Current.Dispatcher.Invoke(() => { MessageSnackbar.IsActive = false; });
        }
        

        #region Windows tools

        public void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseIcon_Click(object sender, MouseButtonEventArgs e)
        {
            Window window = Window.GetWindow((DependencyObject)sender);
            window?.Close();
        }

        #endregion

        //at change of JT selection do the Request DET_Table Name and select by Name all record.Finally print record into the DataGrid
        public async void JobTemplateSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (JobTemplateComboBox.SelectionBoxItem != null || (string)JobTemplateComboBox.SelectionBoxItem! != "")
            {
                JobTemplateDto selectedJobTemplateDto = (JobTemplateDto)JobTemplateComboBox.SelectedItem;
                _entityDescriptors =
                    await _integrationApi.GetEntityDescriptorsByJobTemplateIdAsync(selectedJobTemplateDto.Id ?? 0);
                _detDefinition = await GetDET(selectedJobTemplateDto.Id ?? 0); //if null then 0
                _selectedJobTemplateDto = selectedJobTemplateDto;

                var entities = GetEntitiesName();
                CreateEmptyCsvFile(entities);
                
                //select all records from det when the job template was selected, and show the results in datagrid.
                Dispatcher.Invoke(LoadData);

                StartJobBtn.IsEnabled = true;
            }
            else
            {
                StartJobBtn.IsEnabled = false;
            }
        }

        private void LoadData()
        {
            if (JobTemplateComboBox.SelectedItem != null && JobTemplateComboBox.SelectedIndex != -1)
            {
                _dataTable = _dbPgManager.GetDataForUI(_detDefinition.TableName);
                DETDataGrid.ItemsSource = _dataTable.DefaultView;
            }
        }
        
        private async void GetJoblist()
        {
            try
            {
                var jobTemplateList = await _integrationApi.FindJobTemplatesAsync().ConfigureAwait(false);
                Dispatcher.Invoke(() =>
                {
                    foreach (var item in jobTemplateList.Items)
                    {
                        JobTemplateComboBox.Items.Add(item);
                    }

                    JobTemplateComboBox.IsEnabled = true;
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e);
            }
        }

        private void InsertEmptyRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            var tablename = _detDefinition.TableName;
            _dbPgManager.InsertEmptyRecord(_entityDescriptors, tablename);
            LoadData();
        }

        private void InsertIntegratorDataBtn_Click(object sender, RoutedEventArgs e)
        {
            var tableName = _detDefinition.TableName;
            try
            {
                var data = _dbSqlLiteManager.selectAllIntegratorDataTable();
                if (data.Count == 0)
                    return;
                _dbPgManager.InsertIntegratorData(_entityDescriptors, tableName, data);
                LoadData();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        
        
        //Get Entities Name when JT is selected and extract the only entities that contain Personalization Data
        private List<EntityDescriptor> GetEntitiesName()
        {
            var jobId = _selectedJobTemplateDto.Id;
            if(jobId is null)
                jobId = -1;
            try
            {
                var entities =  _integrationApi.GetEntityDescriptorsByJobTemplateId(jobId.Value);

                return entities;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void CreateEmptyCsvFile(List<EntityDescriptor> entities)
        {
            var tableName = _detDefinition.TableName;
            tableName = tableName.Replace("\"", ""); 
            var csvName = tableName + ".csv";
            
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Asset", csvName);

            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    foreach (var entity in entities)
                    {
                        sw.Write(entity.EntityName + ";");
                    }
                }
            }
        }

        
        //Get data that contains personalization for the insert into the DetTable
        private List<string[]> GetCsvData()
        {
            var tableName = _detDefinition.TableName;
            tableName = tableName.Replace("\"", "");
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Asset", tableName + ".csv");

            var lines = File.ReadAllLines(filePath);
            var data = new List<string[]>();
            
            foreach (var line in lines)
            {
                var values = line.Split(';');
                data.Add(values);
            }

            return data;
        }
        
        
        private void InsertCsvDataBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _pollingTimer.Stop();
                var entities = GetEntitiesName();
                var csvRows = GetCsvData();
                
                if (entities is null || csvRows is null)
                    return;
                
                _dbPgManager.InsertCsvData(_detDefinition.TableName, entities, csvRows);
                LoadData();
                _pollingTimer.Start();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private async void CreateDynamicColumns(int jobid)
        {
            try
            {
                _dataRecordFields = new List<DataRecordField>();
                var entities = await _integrationApi.GetEntityDescriptorsByJobTemplateIdAsync(jobid);
                foreach (var entity in entities)
                {
                    var column = new DataRecordField(entity.EntityName, null);
                    _dataRecordFields.Add(column);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private async Task<DataExchangeTableDefinition> GetDET(int jobid)
        {
            try
            {
                var detDefinition = await _integrationApi.GetDataExchangeTableDefinitionAsync(jobid);
                return detDefinition;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #region Issuance Button

        private async void StartJobBtn_Click(object sender,
            RoutedEventArgs routedEventArgs)
        {
            try
            {
                Dispatcher.Invoke(UpdateUI);
                
                int stopAfter = 0;

                if (StopAfterNCards.IsChecked == true && !string.IsNullOrWhiteSpace(NOfCards.Text) &&
                    int.TryParse(NOfCards.Text, out stopAfter))
                {
                    await _integrationApi.StartWorkflowSchedulerAsync(
                        new WorkflowSchedulerStartupParamsDto(
                            jobTemplateName: _selectedJobTemplateDto.Name,
                            dryRun: DisableLaserSource.IsChecked, 
                            disableRedPointer: DisableRedPointer.IsChecked, 
                            stopAfter:stopAfter
                        )).ConfigureAwait(false);
                }
                else
                {
                    await _integrationApi.StartWorkflowSchedulerAsync(
                        new WorkflowSchedulerStartupParamsDto(
                            jobTemplateName: _selectedJobTemplateDto.Name,
                            dryRun: DisableLaserSource.IsChecked, 
                            disableRedPointer: DisableRedPointer.IsChecked
                        )).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Failed to start workflow scheduler");
            }
        }

        private async void StopJobBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _integrationApi.StopWorkflowSchedulerAsync(false);
                Dispatcher.Invoke(UpdateUI);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
        
        private async void StopJobAndCurrentRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _integrationApi.StopWorkflowSchedulerAsync(true).ConfigureAwait(false);
                Dispatcher.Invoke(UpdateUI);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private async void ResumeJobBtn_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                _cancellationTokenSource = new CancellationTokenSource();
                await _integrationApi.ResumeWorkflowSchedulerAsync(_cancellationTokenSource.Token);
                Dispatcher.Invoke(UpdateUI);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        #endregion

        private void ClearRecordsBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _dbPgManager.ClearTable(_detDefinition.TableName);
                LoadData();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
        
        private void UpdateUI()
        {
            StartJobBtn.IsEnabled = false;
            StopJobBtn.IsEnabled = false;
            StopJobAndCurrentRecordBtn.IsEnabled = false;
            ResumeJobBtn.IsEnabled = false;
            
            if (_connectionStatus == ConnectionStatus.Connected && JobTemplateComboBox.SelectionBoxItem != null &&
                JobTemplateComboBox.SelectionBoxItem != "")
            {
                MachineAddress.IsEnabled = false;
                ConnectBtn.IsEnabled = false;
                JobTemplateComboBox.IsEnabled = true;
                ClearRecordsBtn.IsEnabled = true;
                InsertEmptyJobRecordBtn.IsEnabled = true;
                InsertCsvDataBtn.IsEnabled = true;

                switch (_workflowSchedulerStateDto.Status)
                {
                    case WorkflowSchedulerStatus.Starting:
                    case WorkflowSchedulerStatus.Running:
                    case WorkflowSchedulerStatus.Waiting:
                        StopJobBtn.IsEnabled = true;
                        break;
                    case WorkflowSchedulerStatus.Stopping:
                        StopJobAndCurrentRecordBtn.IsEnabled = true;
                        ResumeJobBtn.IsEnabled = true;
                        break;
                    case WorkflowSchedulerStatus.Stopped:
                    case WorkflowSchedulerStatus.Error:
                        StartJobBtn.IsEnabled = true;
                        break;
                }

                if (_dataTable.Rows.Count > 0)
                {
                    bool containsError = _dataTable.AsEnumerable()
                        .Where(row => row["workflow_status"] != DBNull.Value && row["workflow_status"].ToString() != "Finished") 
                        .Any(row => row["job_error_code"] != DBNull.Value && row["job_error_code"].ToString().Contains("FeederEmpty"));

                    if (containsError)
                    {
                        ResumeJobBtn.IsEnabled = true;
                    }
                }

                switch (_workflowSchedulerStateDto.StopReason)
                {
                    case WorkflowSchedulerStopReason.FeederEmpty:
                    case WorkflowSchedulerStopReason.CardJam:
                        StopJobBtn.IsEnabled = true;
                        StopJobAndCurrentRecordBtn.IsEnabled = true;
                        ResumeJobBtn.IsEnabled = true;
                        break;
                }
            }

            if (_connectionStatus == ConnectionStatus.Disconnected)
            {
                ConnectBtn.IsEnabled = true;
                JobTemplateComboBox.IsEnabled = false;
                ClearRecordsBtn.IsEnabled = false;
                InsertEmptyJobRecordBtn.IsEnabled = false;
                InsertCsvDataBtn.IsEnabled = false;
                JobTemplateComboBox.IsEnabled = false;
            }
            
        }
        
        
        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            MessageSnackbar.IsActive = false;
        }
    }
}