using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class Contexto : DbContext
   {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {

         if (!optionsBuilder.IsConfigured)
         {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("HerokuConnection");

            optionsBuilder.UseLazyLoadingProxies().UseNpgsql(connectionString);
         }
      }
   }
}
