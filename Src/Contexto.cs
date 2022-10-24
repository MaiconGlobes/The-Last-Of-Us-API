﻿using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class Contexto : DbContext
   {
      public DbSet<SobreModel> SOBRE { get; set; }
      public DbSet<LancamentoModel> LANCAMENTO { get; set; }

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
         modelBuilder.Entity<LancamentoModel>().HasOne(lancamento => lancamento.Sobre).WithMany(sobre => sobre.Lancamentos).HasForeignKey(lancamento => lancamento.Sobre_id);
         modelBuilder.Entity<GeneroModel>().HasOne(genero => genero.Sobre).WithMany(genero => genero.Generos).HasForeignKey(genero => genero.Sobre_id);
         #endregion

         #region Auto Generator
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Id).ValueGeneratedOnAdd();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Id).ValueGeneratedOnAdd();
         modelBuilder.Entity<GeneroModel>().Property(genero => genero.Id).ValueGeneratedOnAdd();
         #endregion

         #region Unique
         modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Titulo).IsUnique();
         modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Descricao).IsUnique();
         modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Missao).IsUnique();
         modelBuilder.Entity<LancamentoModel>().HasIndex(lancamento => lancamento.Data).IsUnique();
         modelBuilder.Entity<LancamentoModel>().HasIndex(lancamento => lancamento.Versao).IsUnique();
         modelBuilder.Entity<GeneroModel>().HasIndex(genero => genero.Descricao).IsUnique();
         #endregion

         #region Required
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Titulo).IsRequired();
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Descricao).IsRequired();
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Missao).IsRequired();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Data).IsRequired();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Versao).IsRequired();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Sobre_id).IsRequired();
         modelBuilder.Entity<GeneroModel>().Property(genero => genero.Sobre_id).IsRequired();
         #endregion

         #region Popular Dados
         modelBuilder.Entity<SobreModel>().HasData(PopularDadosUtils.Instancia().PopularSobre());
         modelBuilder.Entity<LancamentoModel>().HasData(PopularDadosUtils.Instancia().PopularLancamento());
         modelBuilder.Entity<GeneroModel>().HasData(PopularDadosUtils.Instancia().PopularGenero());
         #endregion
      }
   }
}
