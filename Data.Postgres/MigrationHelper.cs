using System.Text;
using Ardalis.GuardClauses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProSoft.ITIM.Data.Postgres;

public static class MigrationHelper
{
   public static IHost Migrate<T>(IHost host) where T : DbContext
   {
      Guard.Against.Null(host, nameof(host));

      using (var scope = host.Services.CreateScope())
      {
         var services = scope.ServiceProvider;
         var logger = services.GetRequiredService<ILogger<DbContext>>();

         try
         {
            logger.LogInformation("Checking for pending database migrations");
            var db = services.GetRequiredService<T>();
            var pendingMigrations = db.Database.GetPendingMigrations().ToList();

            if (pendingMigrations.Any())
            {
               var logMessage = new StringBuilder();

               logMessage.Append($"Found {pendingMigrations.Count} pending migrations:");

               foreach (var migration in pendingMigrations)
               {
                  logMessage.Append($"\r\n- {migration}");
               }

               logger.LogInformation(logMessage.ToString());
               db.Database.Migrate();
               logger.LogInformation("Migrations successfully applied.");
            }
            else
            {
               logger.LogInformation("No pending migrations to apply.");
            }
         }
         catch (Exception ex)
         {
            logger.LogError(ex, "An error occurred while migrating the database.");
         }
      }
      return host;
   }


}
