using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class Contexto : DbContext
   {
      public DbSet<Sobre> SOBRE { get; set; }

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

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         #region Chaves Primárias
         //
         #endregion

         #region Auto Generator
         modelBuilder.Entity<Sobre>().Property(about => about.Id).ValueGeneratedOnAdd();
         #endregion

         #region Unique
         //
         #endregion

         #region Required
         //
         #endregion

         #region Popular Dados
         modelBuilder.Entity<Sobre>().HasData(PopularDadosUtils.Instancia().PopularSobre());
         #endregion
      }

      
   }
}
