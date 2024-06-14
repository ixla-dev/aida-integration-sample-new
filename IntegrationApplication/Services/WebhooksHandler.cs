using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;

namespace integratorApplication.Services
{
    public class WebhooksHandler
    {
        public string ApiBaseUrl { get; set; }

        public delegate void MessageReceivedHandler(WebhooksHandler handler, WorkflowMessage message);
        public delegate void MessageHandledHandler(WebhooksHandler sender, WorkflowMessage message);

        public event MessageReceivedHandler MessageReceived;
        public event MessageHandledHandler MessageHandled;
        public List<WorkflowMessage> MessagesToProcess { get; set; } = new();
        public bool ContainsMessage(WorkflowMessage message)
            => MessagesToProcess.Any(m => string.Equals(m.WorkflowInstanceId, message.WorkflowInstanceId));

        public WorkflowMessage GetMessageByIndex(int index) => MessagesToProcess[index];
        public WorkflowMessage GetMessageByWorkflowInstanceId(string workflowInstanceId)
            => MessagesToProcess.FirstOrDefault(m => string.Equals(m.WorkflowInstanceId, workflowInstanceId));

        public WebhooksHandler()
        {
        }

        public void Add(WorkflowMessage message, bool force = false)
        {
            if (!ContainsMessage(message))
                MessagesToProcess.Add(message);
            MessageReceived?.Invoke(this, message);
        }

        public void Remove(WorkflowMessage message)
        {
            if (ContainsMessage(message))
                MessagesToProcess.Remove(message);
            MessageHandled?.Invoke(this, message);
        }

        public void OnWorkflowFaulted(WorkflowFaultedMessage message)
        {
            var m = GetMessageByWorkflowInstanceId(message.WorkflowInstanceId);
            if (m != null) Remove(m);
        }

        public void OnWorkflowCompleted(WorkflowCompletedMessage message)
        {
            var m = GetMessageByWorkflowInstanceId(message.WorkflowInstanceId);
            if (m != null)
                Remove(m);
        }

        public async Task MarkRejected(WorkflowMessage message)
        {
            // For the sake of simplicity i didn't add timeout/retry logic here 
            // but it might be a good idea, since transient failures are always possible 
            // in distributed applications
            using var api = new IntegrationApi(ApiBaseUrl);

            // Signal AIDA that the external process (encoding/ocr validation) has completed
            await api.SignalExternalProcessCompletedAsync(
                // if set to true, the server will return the response when the workflow 
                // finishes 
                waitForCompletion: false,
                new ExternalProcessCompletedMessage
                {
                    // Tells AIDA what action should it take when it receives the notification
                    RequiredAction = WorkflowAction.Reject,
                    // we tell AIDA the operation failed
                    Outcome = ExternalProcessOutcome.Faulted,
                    ErrorReason = "Manually rejected",
                    WorkflowInstanceId = message.WorkflowInstanceId
                }).ConfigureAwait(false);
        }

        public async Task MarkCompleted(WorkflowMessage message)
        {
            using var api = new IntegrationApi(ApiBaseUrl);
            await api.SignalExternalProcessCompletedAsync(
                // if set to true, the server will return the response when the workflow 
                // finishes 
                waitForCompletion: false,
                new ExternalProcessCompletedMessage
                {
                    Outcome = ExternalProcessOutcome.Completed,
                    RequiredAction = WorkflowAction.Resume,
                    WorkflowInstanceId = message.WorkflowInstanceId
                }).ConfigureAwait(false);
        }

        public static async Task FetchSuspendedWorkflows()
        {
        }
    }
}