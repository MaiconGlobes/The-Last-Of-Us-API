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
    public DbSet<IdadeModel> IDADE { get; set; }
    public DbSet<VersaoModel> VERSAO { get; set; }
    public DbSet<PlataformaModel> PLATAFORMA { get; set; }
    public DbSet<DesignerModel> DESIGNER { get; set; }
    public DbSet<FraseModel> FRASE { get; set; }
    public DbSet<GrupoModel> GRUPO { get; set; }
    public DbSet<EspecieModel> ESPECIE { get; set; }
    public DbSet<PersonagemModel> PERSONAGEM { get; set; }

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
      modelBuilder.Entity<FraseModel>().HasOne(frase => frase.Personagem).WithMany(personagem => personagem.Frases).HasForeignKey(frase => frase.Personagem_id);
      modelBuilder.Entity<IdadeModel>().HasOne(idade => idade.Personagem).WithMany(personagem => personagem.Idades).HasForeignKey(idade => idade.Personagem_id);
      modelBuilder.Entity<IdadeModel>().HasOne(idade => idade.Versao).WithMany(versao => versao.Idades).HasForeignKey(idade => idade.Versao_id);
      modelBuilder.Entity<GrupoModel>().HasOne(grupo => grupo.Especie).WithMany(especie => especie.Grupo).HasForeignKey(grupo => grupo.Especie_id);
      modelBuilder.Entity<PersonagemModel>().HasOne(personagem => personagem.Grupo).WithMany(grupo => grupo.Personagem).HasForeignKey(personagem => personagem.Grupo_id);
      #endregion

      #region Auto Generator
      modelBuilder.Entity<PersonagemModel>().Property(personagem => personagem.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<SobreModel>().Property(sobre => sobre.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<LancamentoModel>().Property(lancamento => lancamento.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<PlataformaModel>().Property(plataforma => plataforma.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<DesignerModel>().Property(designer => designer.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<FraseModel>().Property(frase => frase.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<IdadeModel>().Property(idade => idade.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<GrupoModel>().Property(grupo => grupo.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<EspecieModel>().Property(especie => especie.Id).ValueGeneratedOnAdd();
      modelBuilder.Entity<VersaoModel>().Property(versao => versao.Id).ValueGeneratedOnAdd();
      #endregion

      #region Unique
      modelBuilder.Entity<PersonagemModel>().HasIndex(personagem => personagem.Nome).IsUnique();
      modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Titulo).IsUnique();
      modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Sinopse).IsUnique();
      modelBuilder.Entity<SobreModel>().HasIndex(sobre => sobre.Missao).IsUnique();
      modelBuilder.Entity<LancamentoModel>().HasIndex(lancamento => lancamento.Data).IsUnique();
      modelBuilder.Entity<DesignerModel>().HasIndex(designer => designer.Nome).IsUnique();
      modelBuilder.Entity<FraseModel>().HasIndex(frase => frase.Descricao).IsUnique();
      modelBuilder.Entity<GrupoModel>().HasIndex(grupo => grupo.Tipo).IsUnique();
      modelBuilder.Entity<EspecieModel>().HasIndex(especie => especie.Definicao).IsUnique();
      modelBuilder.Entity<VersaoModel>().HasIndex(versao => versao.Descricao).IsUnique();
      #endregion

      #region Required
      modelBuilder.Entity<PersonagemModel>().Property(personagem => personagem.Nome).IsRequired();
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
      modelBuilder.Entity<FraseModel>().Property(frase => frase.Personagem_id).IsRequired();
      modelBuilder.Entity<IdadeModel>().Property(idade => idade.Idade).IsRequired();
      modelBuilder.Entity<GrupoModel>().Property(grupo => grupo.Tipo).IsRequired();
      modelBuilder.Entity<EspecieModel>().Property(especie => especie.Definicao).IsRequired();
      modelBuilder.Entity<VersaoModel>().Property(versao => versao.Descricao).IsRequired();
      #endregion

      #region Popular Dados
      modelBuilder.Entity<SobreModel>().HasData(PopularDadosUtils.Instancia().PopularSobre());
      modelBuilder.Entity<LancamentoModel>().HasData(PopularDadosUtils.Instancia().PopularLancamento());
      modelBuilder.Entity<PlataformaModel>().HasData(PopularDadosUtils.Instancia().PopularPlataforma());
      modelBuilder.Entity<DesignerModel>().HasData(PopularDadosUtils.Instancia().PopularDesigner());
      modelBuilder.Entity<PersonagemModel>().HasData(PopularDadosUtils.Instancia().PopularPersonagem());
      modelBuilder.Entity<VersaoModel>().HasData(PopularDadosUtils.Instancia().PopularVersao());
      modelBuilder.Entity<EspecieModel>().HasData(PopularDadosUtils.Instancia().PopularEspecie());
      modelBuilder.Entity<GrupoModel>().HasData(PopularDadosUtils.Instancia().PopularGrupo());
      modelBuilder.Entity<FraseModel>().HasData(PopularDadosUtils.Instancia().PopularFrase());
      #endregion
    }
  }
}
