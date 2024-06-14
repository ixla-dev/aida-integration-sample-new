using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Sdk.Mini.Api;
using Serilog;
using Aida.Samples.WebhooksReceiverConsole.HostedServices;
using IntegratoApplicaton.WebhooksReceiver;
using WebhooksReceiver.Messaging;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
builder.Host.UseSerilog((context, services, configuration) => 
    configuration.ReadFrom.Configuration(context.Configuration)
        .Enrich.FromLogContext());

// Add services to the container.
builder.Services.AddSingleton<MessageCollection>();
//builder.Services.AddSingleton<ILogger<WebhooksController>, Logger<WebhooksController>>();

builder.Services.AddScoped(_ =>
{
    var options = new JsonSerializerOptions();
    options.Converters.Add(new JsonStringEnumConverter());
    options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    return options;
});
builder.Services.AddTransient<ApiClientFactory>(_ => machineAddress =>
{
    var url = $"http://{machineAddress}:5000";
    return new IntegrationApi(url);
});
builder.Services.AddOptions();
builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddHostedService<MessagesBackgroundWorker>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());

var port = app.Configuration.GetValue("Port", 7654);
Console.WriteLine($"Server listening on port: {port}");

app.Run($"http://0.0.0.0:{port}");

public delegate IntegrationApi ApiClientFactory(string id);