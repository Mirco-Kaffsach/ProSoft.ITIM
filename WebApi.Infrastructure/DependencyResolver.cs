using Ardalis.GuardClauses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProSoft.ITIM.Logic.Infrastructure;

namespace ProSoft.ITIM.WebApi.Infrastructure;

public static class DependencyResolver
{
   public static IServiceCollection AddProSoftITInventoryManagement(this IServiceCollection services)
   {
      Guard.Against.Null(services);



      return services;
   }

   public static IHost UseProSoftITInventoryManagement(this IHost host, ILogger logger)
   {
      Guard.Against.Null(host);
      Guard.Against.Null(logger);

      logger.LogInformation("Configure dependencies for: ProSoft.ITIM.WebApi");
      host.UseProSoftITInventoryManagementLogic(logger);

      return host;
   }
}
