using System.Net;
using System.Reflection.Metadata;
using ProSoft.ITIM.Core.Extensions;
using ProSoft.ITIM.WebApi.Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Logging
builder.Host.UseSerilog
(
   (hostingContext, logConfig) => logConfig.ReadFrom.Configuration(hostingContext.Configuration)
);

// Add services to the container.
builder.Services
   .AddProSoftITInventoryManagement()
   .AddControllers()
   ;

var ipv4String = "10.215.10.90";
var ipv6String = "2001:0db8:0000:0001:0000:0000:0000:0001";
var ip = IPAddress.Parse(ipv4String);
var ipv6 = IPAddress.Parse(ipv6String);

var test1 = ipv4String.ToIPv4Address();
var test2 = ipv6String.ToIPv6Address();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILogger<Program>>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseProSoftITInventoryManagement(logger);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
logger.LogInformation("WebApi is up and ready for requests.");
app.Run();
