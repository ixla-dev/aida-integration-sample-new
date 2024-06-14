using System.Data;
using System.Windows;
using System.Windows.Input;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;

namespace integratorApplication;

public partial class Issuance_View_Windows : Window
{
    public Issuance_View_Windows(WorkflowSchedulerStateDto workflowSchedulerStateDto)
    {
        InitializeComponent();
            IssuanceDataGrid.DataContext = workflowSchedulerStateDto;
    }
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
}