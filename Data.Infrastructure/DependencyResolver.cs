using Ardalis.GuardClauses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProSoft.ITIM.Data.Postgres;

namespace ProSoft.ITIM.Data.Infrastructure;

public static class DependencyResolver
{
   public static IServiceCollection AddProSoftITInventoryManagementData(this IServiceCollection services)
   {
      Guard.Against.Null(services);

      services
         .AddProSoftITInventoryManagementPostgresDatabase()
         ;

      return services;
   }

   public static IHost UseProSoftITInventoryManagementData(this IHost host, ILogger logger)
   {
      Guard.Against.Null(host);
      Guard.Against.Null(logger);

      logger.LogInformation("Configure dependencies for: ProSoft.ITIM.Data");

      host.UseProSoftITInventoryManagementPostgresDatabase(logger);

      return host;
   }
}
