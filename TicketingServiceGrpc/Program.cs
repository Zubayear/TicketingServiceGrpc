using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using TicketingServiceGrpc.Repository;
using TicketingServiceGrpc.Services;

var builder = WebApplication.CreateBuilder(args);

// DynamoDB
var aWsOptions = builder.Configuration.GetAWSOptions();
builder.Services.AddDefaultAWSOptions(aWsOptions);
builder.Services.AddAWSService<IAmazonDynamoDB>();
builder.Services.AddScoped<IDynamoDBContext, DynamoDBContext>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
    
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(7974, o => o.Protocols = HttpProtocols.Http2);
});
// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<TicketService>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();