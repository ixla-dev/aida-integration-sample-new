
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Configuration;
using WebhooksReceiver;
using WebhooksReceiver.Messaging;

namespace Aida.Samples.WebhooksReceiverConsole.HostedServices
{
    /// <summary>
    /// Hosted service that processes messages from AIDAMessageCollection 
    /// </summary>
    public class MessagesBackgroundWorker(
        IConfiguration configuration,
        MessageCollection messages,
        ApiClientFactory clientFactory,
        ILogger<MessagesBackgroundWorker> logger)
        : IHostedService
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions = new()
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        /// <summary>
        /// Starts an async task 
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        public async Task StartAsync(CancellationToken stoppingToken)
        {
            _ = ProcessMessages(stoppingToken).ConfigureAwait(false);
            logger.LogInformation("Message processor started");
        }
        public async Task ProcessMessages(CancellationToken cancellationToken)
        {
            logger.LogInformation("Server started. Waiting messages...");
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var aidaMessage = messages.TakeMessage();
                    if (aidaMessage is null)
                    {
                        await Task.Delay(250, default);
                        continue;
                    }

                    var eventMessage = aidaMessage.Message;
                    if (eventMessage.JobId is null)
                        logger.LogInformation("Message {MessageType}", eventMessage.MessageType);
                    if (eventMessage.JobId is not null)
                        logger.LogInformation(
                            "CorrelationId: {CorrelationId} job id: {JobId}, event: {WorkflowEvent} status: {Status}, error code: {ErrorCode}, document produced: {DocumentProduced}",
                            eventMessage.CorrelationId,
                            eventMessage.JobId,
                            eventMessage.MessageType,
                            eventMessage.JobStatus,
                            eventMessage.ErrorCode,
                            eventMessage.DocumentProduced);

                    var ipAddress = aidaMessage.IpAddress;
                    var client    = clientFactory(ipAddress);

                    // logger.LogInformation("Processing message {AidaMessageType}", eventMessage.GetType().Name);

                    switch (eventMessage)
                    {
                        case WorkflowSchedulerStoppedMessage stopped:
                            logger.LogWarning("Workflow Scheduler stopped. Error code = {ErrorCode}, stop reason = {StopReason}, source job id = {SourceJobId}",
                                stopped.ErrorCode,
                                stopped.StopReason,
                                stopped.SourceJobInstanceId);
                            break;

                        case WorkflowSchedulerStartedMessage started:
                            logger.LogInformation("Workflow Scheduler started");
                            break;
                        // These are notifications that indicate that the workflow was suspended
                        // The workflow was suspended because AIDA was not able to get the card 
                        // from the feeder or it was about to move a card in the engraving position but open interlocks where found.
                        case WorkflowSchedulerProcessSuspendedMessage suspended:
                            switch (suspended.ErrorCode)
                            {
                                case JobErrorCodes.CardJam: break;

                                case JobErrorCodes.FeederEmpty:
                                    // Intentionally block until we receive user input 
                                    logger.LogWarning("\n\nFeeder empty\nLoad the input feeder with cards and press the 'Resume' button");
                                    break;
                                case JobErrorCodes.OpenInterlock:
                                    logger.LogWarning("\n\n Open interlocks detected. Please verify all interlocks are properly locked, then click the 'Resume'");
                                    break;
                            }

                            break;
                        // These are fire and forget for AIDA. 
                        case WorkflowCancelledMessage: break;
                        case WorkflowCompletedMessage: break;
                        case WorkflowFaultedMessage:   break;

                        case MagneticStripeReadBackMessage readBack:
                            logger.LogInformation("MAGNETIC READ_BACK RECEIVED");
                            _ = MockReadBackValidation(readBack, client);
                            break;

                        // These events require the receiving application to invoke SignalExternalProcessCompleted.
                        // The card is positioned in the SmartCard reader. AIDA is waiting the external application
                        // to signal the completion (and outcome) of the operation.
                        case EncoderLoadedMessage encoderLoaded:
                            // Mock the chip personalization process.
                            _ = MockChipEncodingPersonalization(encoderLoaded, client, CancellationToken.None).ConfigureAwait(false);
                            break;

                        // AIDA executed an OCR operation successfully. The notification contains the list of results
                        // obtained from the OCR reading, it now expects the receiving application to validate the 
                        // results and signal the outcome of the validation 
                        case OcrExecutedMessage ocrMessage:
                            _ = MockOcrValidation(ocrMessage, client, CancellationToken.None).ConfigureAwait(false);
                            break;
                    }
                }
                catch (Exception e)
                {
                    logger.LogError(e, "Failed to process AIDA notification");
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        public async Task MockReadBackValidation(MagneticStripeReadBackMessage readBack, IntegrationApi api)
        {
            try
            {
                var response = new ExternalProcessCompletedMessage()
                {
                    Outcome = ExternalProcessOutcome.Completed,
                    WorkflowInstanceId = readBack.WorkflowInstanceId
                };
                await api.SignalExternalProcessCompletedAsync(false, response).ConfigureAwait(false);
            }
            catch
            {
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="api"></param>
        /// <param name="cancellationToken"></param>
        private async Task MockOcrValidation(OcrExecutedMessage message, IntegrationApi api, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
            try
            {
                var responseMessage = new ExternalProcessCompletedMessage
                {
                    // We tell AIDA chip personalization completed without error
                    Outcome = ExternalProcessOutcome.Completed,
                    // This is the WorkflowInstanceId we received in the webhook notification
                    WorkflowInstanceId = message.WorkflowInstanceId,
                };

                logger.LogInformation("Ocr Validation completed {Validation}", JsonSerializer.Serialize(message, _jsonSerializerOptions));
                // tell AIDA to dispatch the completion signal and resume 
                await api.SignalExternalProcessCompletedAsync(
                        // waitForCompletion = false tells aida to return immediately the
                        // HTTP response without waiting the workflow to finish 
                        waitForCompletion: false,
                        // The response message
                        externalProcessCompletedMessage: responseMessage,
                        cancellationToken)
                    .ConfigureAwait(false);

                logger.LogInformation("Message published. Outcome = {Outcome}, WorkflowId = {WorkflowId}, {Message}",
                    responseMessage.Outcome,
                    responseMessage.WorkflowInstanceId,
                    JsonSerializer.Serialize(message, _jsonSerializerOptions));
            }
            catch (Exception e)
            {
                logger.LogError(e, "OCR Validation Resume Failed");
            }
        }

        /// <summary>
        /// Mock chip personalization by waiting for a predefined amount of time before sending the completed notification to AIDA
        /// </summary>
        /// <param name="message"></param>
        /// <param name="api"></param>
        /// <param name="cancellationToken"></param>
        private async Task MockChipEncodingPersonalization(WorkflowMessage message, IntegrationApi api, CancellationToken cancellationToken)
        {
            try
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                var errorRate = configuration.GetValue("EncodingErrorRate", 0);
                var rnd       = new Random();
                var value     = rnd.Next(0, 100);
                var outcome   = value < errorRate ? ExternalProcessOutcome.Faulted : ExternalProcessOutcome.Completed;

                var duration = TimeSpan.Parse(configuration.GetValue<string>("MockEncodingDuration"));
                logger.LogInformation("Mocking chip encoding, jobId = {JobId}, duration = {Duration}", message.JobId, duration);
                await Task.Delay(duration, cancellationToken).ConfigureAwait(false);

                var responseMessage = new ExternalProcessCompletedMessage
                {
                    // We tell AIDA chip personalization completed without error
                    Outcome = outcome,
                    // This is the WorkflowInstanceId we received in the webhook notification
                    WorkflowInstanceId = message.WorkflowInstanceId
                };

                logger.LogInformation("CorrelationId: {CorrelationId}, job id: {JobId}, Chip Perso: {OperationOutcome}", message.CorrelationId, message.JobId, outcome);
                // tell AIDA to dispatch the completion signal and resume 
                await api.SignalExternalProcessCompletedAsync(
                    // waitForCompletion = false tells aida to return immediately the HTTP response without waiting the workflow to finish 
                    waitForCompletion: false,
                    // The response message
                    externalProcessCompletedMessage: responseMessage,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                logger.LogError(e, e.Message);
            }
        }
    }
}