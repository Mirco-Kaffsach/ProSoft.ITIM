using Ardalis.GuardClauses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProSoft.ITIM.Data.Infrastructure;

namespace ProSoft.ITIM.Logic.Infrastructure;

public static class DependencyResolver
{
   public static IServiceCollection AddProSoftITInventoryManagementLogic(this IServiceCollection services)
   {
      Guard.Against.Null(services);



      return services;
   }

   public static IHost UseProSoftITInventoryManagementLogic(this IHost host, ILogger logger)
   {
      Guard.Against.Null(host);
      Guard.Against.Null(logger);

      logger.LogInformation("Configure dependencies for: ProSoft.ITIM.Logic");

      host.UseProSoftITInventoryManagementData(logger);

      return host;
   }
}
