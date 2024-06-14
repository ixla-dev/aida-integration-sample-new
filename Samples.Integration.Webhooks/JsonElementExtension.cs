using System.Text.Json;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Logging;

namespace Samples.Integration.Webhooks;

public static class JsonElementExtensions
{
    //extend JsonElement with static method TryParseTryParseWorkflowMessage
    public static bool TryParseWorkflowMessage(this JsonElement jsonElement, JsonSerializerOptions serializerOptions,
        ILogger logger, out WorkflowMessage? message)
    {
        message = null;
        try
        {
            //convert in Enum (of type MessageType) the value of the string where the element of JsonElement is messageType
            if (!Enum.TryParse<MessageType>(jsonElement.GetProperty("messageType").GetString(), out var messageType))
            {
                return false;
            }

            var jsonString = jsonElement.ToString();
            //check the message type and deserialize the json string into the corresponding object
            message = messageType switch
            {
                MessageType.WorkflowSchedulerSuspended => JsonSerializer.Deserialize<WorkflowSchedulerProcessSuspendedMessage>(jsonString, serializerOptions),
                MessageType.WorkflowSchedulerStarted   => JsonSerializer.Deserialize<WorkflowSchedulerStartedMessage>(jsonString, serializerOptions),
                MessageType.WorkflowSchedulerStopped   => JsonSerializer.Deserialize<WorkflowSchedulerStoppedMessage>(jsonString, serializerOptions),
                MessageType.WorkflowStarted            => JsonSerializer.Deserialize<WorkflowStartedMessage>(jsonString, serializerOptions),
                MessageType.WorkflowCancelled          => JsonSerializer.Deserialize<WorkflowCancelledMessage>(jsonString, serializerOptions),
                MessageType.WorkflowCompleted          => JsonSerializer.Deserialize<WorkflowCompletedMessage>(jsonString, serializerOptions),
                MessageType.WorkflowFaulted            => JsonSerializer.Deserialize<WorkflowFaultedMessage>(jsonString, serializerOptions),
                MessageType.EncoderLoaded              => JsonSerializer.Deserialize<EncoderLoadedMessage>(jsonString, serializerOptions),
                MessageType.OcrExecuted                => JsonSerializer.Deserialize<OcrExecutedMessage>(jsonString, serializerOptions),
                MessageType.HealthCheck                => JsonSerializer.Deserialize<WebhookReceiverHealthCheckMessage>(jsonString, serializerOptions),
                MessageType.MagneticStripeReadBack     => JsonSerializer.Deserialize<MagneticStripeReadBackMessage>(jsonString, serializerOptions),
                _                                      => null
            };
            return message != null;

        }
        catch (Exception e)
        {
            logger.LogError(e, e.Message);
            return false;
        }
    }
}