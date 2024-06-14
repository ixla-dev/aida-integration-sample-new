using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using integratorApplication.Backend;
using integratorApplication.Controller;
using integratorApplication.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
        private string _JobStatus;
        private string _JobStopReason;

        private readonly WebhooksHandler _webhooksHandler;
        
        public MainWindow()
        {
            InitializeComponent();
            
            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
            
            
            _pollingTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(200)
            };
            _pollingTimer.Tick += PollingWorkFlowState_Tick;
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
            ConnectBtn.IsEnabled = false;
            string BASE_PATH = $"http://{MachineAddress.Text}:5000";
            _integrationApi = new IntegrationApi(BASE_PATH);
            _dbPgManager = new dbPgManager();
            _dbSqlLiteManager = new dbSqlLiteManager();
            //_pollingTimer.Start();

            // Connect to Machine
            var wfState = await _integrationApi.GetWorkflowSchedulerStateAsync();
            if (wfState != null)
            {
                _connectionStatus = ConnectionStatus.Connected;
                GetJoblist();
                _pollingTimer.Start(); // Start the polling timer after a successful connection
            }
            else
            {
                MessageBox.Show("Incorrect Machine Address");
                ConnectBtn.IsEnabled = true;
                return;
            }

            // Connect to in-app DB
            _dbSqlLiteManager.DbSqlLiteConnect();

            // Connect to Aida DB (PostgreSQL)
            bool isConnected = _dbPgManager.DbPgConnect(MachineAddress.Text);
            
        }

        private void OpenMessageDialog(WorkflowMessage e)
        {
            {
                if (e.ErrorCode != null && e.ErrorCode != JobErrorCodes.NoErrors)
                {
                    string? errorMessage = Enum.GetName(typeof(JobErrorCodes), e.ErrorCode);
                    
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        MessageSnackbar.IsActive = true;
                        SnackbarText.Content = errorMessage;
                    });  
                }
            };
        }

        private async void PollingWorkFlowState_Tick(object? sender, EventArgs e)
        {
            try
            {
                //ping the Machine
                 _workflowSchedulerStateDto = await _integrationApi.GetWorkflowSchedulerStateAsync().ConfigureAwait(false);
                _connectionStatus = ConnectionStatus.Connected;
                Dispatcher.Invoke(UpdateUI);
                
                if (_workflowSchedulerStateDto.Status != null)
                {
                    _JobStatus = _workflowSchedulerStateDto.Status.ToString();
                    
                    //loading of polling data only if the job is active
                    if (_workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Starting ||
                        _workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Waiting ||
                        _workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Running
                        )
                    {
                        Dispatcher.Invoke(LoadData);
                    }
                }
                else
                {
                    _JobStatus = " - ";
                }
                if (_workflowSchedulerStateDto.StopReason != null)
                {
                    _JobStopReason = _workflowSchedulerStateDto.StopReason.ToString();
                }
                else
                {
                    _JobStopReason = " - ";
                }
                
                Application.Current.Dispatcher.Invoke(( )=>
                {
                    StatusTextBlock.Text = $"Status: {_JobStatus}";
                    StopReasonTextBlock.Text = $"Stop Reason: {_JobStopReason}";
                    if ( _JobStatus == WorkflowSchedulerStatus.Running.ToString() ||
                        _JobStatus == WorkflowSchedulerStatus.Starting.ToString() ||
                        _JobStatus == WorkflowSchedulerStatus.Waiting.ToString())
                    {
                        ProgressBar.IsIndeterminate = true;
                    }
                    else
                    {
                        ProgressBar.IsIndeterminate = false;
                    }
                });
            }
            catch (Exception exception)
            {
                Console.WriteLine("Disconnected");
                _connectionStatus = ConnectionStatus.Disconnected;
                Dispatcher.Invoke(() => UpdateUI());
            }
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
            if (JobTemplateComboBox.SelectionBoxItem != null || JobTemplateComboBox.SelectionBoxItem != "")
            {
                JobTemplateDto selectedJobTemplateDto = (JobTemplateDto)JobTemplateComboBox.SelectedItem;
                _entityDescriptors =
                    await _integrationApi.GetEntityDescriptorsByJobTemplateIdAsync(selectedJobTemplateDto.Id ?? 0);
                _detDefinition = await GetDET(selectedJobTemplateDto.Id ?? 0); //if null then 0
                _selectedJobTemplateDto = selectedJobTemplateDto;
                
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
                _dataTable = _dbPgManager.SelectAllFromDET(_detDefinition.TableName);
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
            }
        }

        private void InsertEmptyRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            var tablename = _detDefinition.TableName;
            _dbPgManager.InsertEmptyRecord(_entityDescriptors, tablename);
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

        private void OpenIssuanceViewWindows()
        {
            var issuanceViewWindows = new Issuance_View_Windows(_workflowSchedulerStateDto);
            issuanceViewWindows.Show();
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
                Dispatcher.Invoke(() =>
                {
                    StartJobBtn.IsEnabled = false;
                    StopJobBtn.IsEnabled = true;
                    StopJobAndCurrentRecordBtn.IsEnabled = true;
                });
                
                
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
                await _integrationApi.StopWorkflowSchedulerAsync(false, JobErrorCodes.ManualStop);
                Dispatcher.Invoke(() =>
                {
                    ResumeJobBtn.IsEnabled = true;
                    StopJobBtn.IsEnabled = false;
                });
                
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
                await _integrationApi.StopWorkflowSchedulerAsync(true, JobErrorCodes.ManualStop);
                Dispatcher.Invoke(() =>
                {
                    StartJobBtn.IsEnabled = true;
                    StopJobBtn.IsEnabled = false;
                    StopJobAndCurrentRecordBtn.IsEnabled = false;
                    ResumeJobBtn.IsEnabled = false;
                });
                
                
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
                Dispatcher.Invoke(() => { ResumeJobBtn.IsEnabled = false; });
                await _integrationApi.ResumeWorkflowSchedulerAsync();
                StopJobBtn.IsEnabled = true;
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
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }


        private void UpdateUI()
        {
            if (_connectionStatus == ConnectionStatus.Connected && JobTemplateComboBox.SelectionBoxItem != null &&
                JobTemplateComboBox.SelectionBoxItem != "")
            {
                ConnectBtn.IsEnabled = false;
                JobTemplateComboBox.IsEnabled = true;
                ClearRecordsBtn.IsEnabled = true;
                InsertEmptyJobRecordBtn.IsEnabled = true;
                InsertIntegratorDataBtn.IsEnabled = true;
            }

            if (_connectionStatus == ConnectionStatus.Disconnected && JobTemplateComboBox.SelectionBoxItem == null)
            {
                ConnectBtn.IsEnabled = true;
                JobTemplateComboBox.IsEnabled = false;
                ClearRecordsBtn.IsEnabled = false;
                InsertEmptyJobRecordBtn.IsEnabled = false;
                InsertIntegratorDataBtn.IsEnabled = false;
            }
            
            //   
            // TODO not all conditions were managed
            //
            
            // if (_workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Starting 
            //     || _workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Running 
            //     || _workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Waiting 
            //     )
            // {
            //     StartJobBtn.IsEnabled = false;
            //     StopJobBtn.IsEnabled = true;
            //     StopJobAndCurrentRecordBtn.IsEnabled = true;
            //     ResumeJobBtn.IsEnabled = false;
            // }
            //
            // if (_workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Error 
            //     || _workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.Stopped
            //     )
            // {
            //     StartJobBtn.IsEnabled = true;
            //     StopJobBtn.IsEnabled = false;
            //     StopJobAndCurrentRecordBtn.IsEnabled = true;
            //     ResumeJobBtn.IsEnabled = false;
            // }
            //
            
            if (_workflowSchedulerStateDto.Status == WorkflowSchedulerStatus.FeederEmpty 
                || _workflowSchedulerStateDto.StopReason == WorkflowSchedulerStopReason.CardJam 
               )
            {
                StartJobBtn.IsEnabled = false;
                StopJobBtn.IsEnabled = true;
                StopJobAndCurrentRecordBtn.IsEnabled = true;
                ResumeJobBtn.IsEnabled = true;
            }
        }
        
        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            MessageSnackbar.IsActive = false;
        }
    }
}