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
