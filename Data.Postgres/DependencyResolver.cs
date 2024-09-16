using Ardalis.GuardClauses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProSoft.ITIM.Data.Postgres;

public static class DependencyResolver
{
   public static IServiceCollection AddProSoftITInventoryManagementPostgresDatabase(this IServiceCollection services)
   {
      Guard.Against.Null(services);



      return services;
   }

   public static IHost UseProSoftITInventoryManagementPostgresDatabase(this IHost host, ILogger logger)
   {
      Guard.Against.Null(host);
      Guard.Against.Null(logger);

      logger.LogInformation("Using Postgres database");

      return host;
   }
}
