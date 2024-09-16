using Ardalis.GuardClauses;
using Microsoft.EntityFrameworkCore;

namespace ProSoft.ITIM.Data.Postgres;

public sealed class ProSoftDbContext : DbContext
{
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      Guard.Against.Null(optionsBuilder);

      if (!optionsBuilder.IsConfigured)
      {
         optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PROSOFT_ITIM_CONNECTIONSTRING"));
      }

      base.OnConfiguring(optionsBuilder);
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      Guard.Against.Null(modelBuilder);

      //modelBuilder.Entity<Building>().ConfigureDatabaseEntity();
   }
}
