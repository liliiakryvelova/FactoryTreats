using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FactoryTreats.Models
{
  public class FactoryTreatsContextFactory : IDesignTimeDbContextFactory<FactoryTreatsContext>
  {

    FactoryTreatsContext IDesignTimeDbContextFactory<FactoryTreatsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<FactoryTreatsContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new FactoryTreatsContext(builder.Options);
    }
  }
}