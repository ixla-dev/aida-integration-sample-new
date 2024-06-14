using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Sdk.Mini.Model;
using integratorApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Samples.Integration.Webhooks;

namespace integratorApplication.Controller;

[ApiController]
public class WebHooksController : ControllerBase
{
    private readonly JsonSerializerOptions _jsonOptions;
    private readonly ILogger<WebHooksController> _logger;
    private readonly WebhooksHandler _webhooksHandler;

    public WebHooksController(
        JsonSerializerOptions jsonOptions,
        WebhooksHandler webhooksHandler,
        ILogger<WebHooksController> logger)
    {
        _jsonOptions = jsonOptions;
        _webhooksHandler = webhooksHandler;
        _logger = logger;
    }

    /// <summary>
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("/index")]
    public ActionResult<string> Index() => Ok("webhooks receiver");


    [HttpPost]
    [Route("/test")]
    public async Task<ActionResult> Test([FromBody] JsonElement test)
    {
        _logger.LogInformation("TEST: {@TEST}", test);
        return Ok(test);
    }
    
    /// <summary>
    /// This is the endpoint that receives webhooks from AIDA. Messages sent by AIDA can be 
    /// distinguished by "MessageType". 
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [Route("/ixla/aida/v1/webhooks")]
    public async Task<ActionResult> OnWebhookReceived([FromBody] JsonElement json)
    {
        try
        {
            var jsonOptions = new JsonSerializerOptions();
            // enable string -> Enum parsing in the json serializer
            jsonOptions.Converters.Add(new JsonStringEnumConverter());

            // Parse messages sent by AIDA: 
            // Polymorphic deserialization can be achieved also using a custom json converter for system.text.json 
            // but i didn't want to implement it, since it would be pretty much overkill for deserializing only 2 
            // different message types
            if (!(json.TryParseWorkflowMessage(_jsonOptions, _logger, out var message)))
                return BadRequest("Unsupported message type");

            switch (message)
            {
                case WorkflowCompletedMessage wfCompleted:
                    _webhooksHandler.OnWorkflowCompleted(wfCompleted);
                    break;
                case WorkflowFaultedMessage wfFault:
                    _webhooksHandler.OnWorkflowFaulted(wfFault);
                    break;
            }

            _webhooksHandler.Add(message);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}