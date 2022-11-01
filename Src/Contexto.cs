using API_REST_The_Last_Of_Us.Src.Models.Entity;
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
      public DbSet<PlataformaModel> PLATAFORMA { get; set; }
      public DbSet<DesignerModel> DESIGNER { get; set; }
      public DbSet<FraseModel> FRASE { get; set; }

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
         #region Relacionaemtno de Tabelas
         modelBuilder.Entity<LancamentoModel>().HasOne(lancamento => lancamento.Sobre).WithMany(sobre => sobre.Lancamentos).HasForeignKey(lancamento => lancamento.Sobre_id);
         modelBuilder.Entity<PlataformaModel>().HasOne(plataforma => plataforma.Sobre).WithMany(sobre => sobre.Plataformas).HasForeignKey(plataforma => plataforma.Sobre_id);
         modelBuilder.Entity<DesignerModel>().HasOne(designer => designer.Sobre).WithMany(sobre => sobre.Designers).HasForeignKey(designer => designer.Sobre_id);
         #endregion

         #region Auto Generator
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Id).ValueGeneratedOnAdd();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Id).ValueGeneratedOnAdd();
         modelBuilder.Entity<PlataformaModel>().Property(plataforma => plataforma.Id).ValueGeneratedOnAdd();
         modelBuilder.Entity<DesignerModel>().Property(designer => designer.Id).ValueGeneratedOnAdd();
         modelBuilder.Entity<FraseModel>().Property(frase => frase.Id).ValueGeneratedOnAdd();
         #endregion

         #region Unique
         modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Titulo).IsUnique();
         modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Sinopse).IsUnique();
         modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Missao).IsUnique();
         modelBuilder.Entity<LancamentoModel>().HasIndex(lancamento => lancamento.Data).IsUnique();
         modelBuilder.Entity<DesignerModel>().HasIndex(designer => designer.Nome).IsUnique();
         modelBuilder.Entity<FraseModel>().HasIndex(frase => frase.Descricao).IsUnique();
         #endregion

         #region Required
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Titulo).IsRequired();
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Sinopse).IsRequired();
         modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Missao).IsRequired();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Data).IsRequired();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Versao).IsRequired();
         modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Sobre_id).IsRequired();
         modelBuilder.Entity<PlataformaModel>().Property(plataforma => plataforma.Versao).IsRequired();
         modelBuilder.Entity<PlataformaModel>().Property(plataforma => plataforma.Console).IsRequired();
         modelBuilder.Entity<PlataformaModel>().Property(plataforma => plataforma.Sobre_id).IsRequired();
         modelBuilder.Entity<DesignerModel>().Property(designer => designer.Nome).IsRequired();
         modelBuilder.Entity<DesignerModel>().Property(designer => designer.Sobre_id).IsRequired();
         modelBuilder.Entity<FraseModel>().Property(frase => frase.Descricao).IsRequired();
         modelBuilder.Entity<FraseModel>().Property(frase => frase.Personagem).IsRequired();
         #endregion

         #region Popular Dados
         modelBuilder.Entity<SobreModel>().HasData(PopularDadosUtils.Instancia().PopularSobre());
         modelBuilder.Entity<LancamentoModel>().HasData(PopularDadosUtils.Instancia().PopularLancamento());
         modelBuilder.Entity<PlataformaModel>().HasData(PopularDadosUtils.Instancia().PopularPlataforma());
         modelBuilder.Entity<DesignerModel>().HasData(PopularDadosUtils.Instancia().PopularDesigner());
         #endregion
      }
   }
}
