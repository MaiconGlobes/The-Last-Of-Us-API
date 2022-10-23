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
      public DbSet<Desenvolvedor> DESENVOLVEDOR { get; set; }

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
         modelBuilder.Entity<Desenvolvedor>()
            .HasOne(desenvolvedor => desenvolvedor.Sobre)
            .WithMany(sobre => sobre.Desenvolvedores)
            .HasForeignKey(desenvolvedor => desenvolvedor.Sobre_id);
         #endregion

         #region Auto Generator
         modelBuilder.Entity<Sobre>().Property(sobre => sobre.Id).ValueGeneratedOnAdd();
         #endregion

         #region Unique
         modelBuilder.Entity<Sobre>().HasIndex(sobre => sobre.Titulo).IsUnique();
         modelBuilder.Entity<Sobre>().HasIndex(sobre => sobre.Descricao).IsUnique();
         modelBuilder.Entity<Sobre>().HasIndex(sobre => sobre.Missao).IsUnique();
         #endregion

         #region Required
         modelBuilder.Entity<Sobre>().Property(sobre => sobre.Titulo).IsRequired();
         modelBuilder.Entity<Sobre>().Property(sobre => sobre.Descricao).IsRequired();
         modelBuilder.Entity<Sobre>().Property(sobre => sobre.Missao).IsRequired();
         #endregion

         #region Popular Dados
         modelBuilder.Entity<Sobre>().HasData(PopularDadosUtils.Instancia().PopularSobre());
         #endregion
      }
   }
}
