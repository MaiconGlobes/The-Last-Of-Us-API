using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
   [Table("Sobre", Schema = "public")]
   public class Sobre
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [JsonPropertyName("id")]
      public Guid Id { get; set; }

      [Column("Titulo")]
      [Required(ErrorMessage = "Propriedade [titulo] é obrigatório")]
      [StringLength(14, ErrorMessage = "Propriedade [titulo] deve ter no máximo 14 caractere")]
      [JsonPropertyName("titulo")]
      public string Titulo { get; set; }

      [Column("Descricao", TypeName = "text")]
      [Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
      [JsonPropertyName("descricao")]
      public string Descricao { get; set; }

      [Column("Missao")]
      [Required(ErrorMessage = "Propriedade [missao] é obrigatório")]
      [StringLength(255, ErrorMessage = "Propriedade [missao] deve ter no máximo 255 caractere")]
      [JsonPropertyName("missao")]
      public string Missao { get; set; }

      [JsonPropertyName("Lancamento")]
      public virtual List<Lancamento> Lancamentos { get; set; }

      [Column("Desenvolvedor")]
      [Required(ErrorMessage = "Propriedade [desenvolvedor] é obrigatório")]
      [StringLength(60, ErrorMessage = "Propriedade [desenvolvedor] deve ter no máximo 60 caractere")]
      [JsonPropertyName("desenvolvedor")]
      public string Desenvolvedor { get; set; }

      [Column("Direito_Autoral")]
      [Required(ErrorMessage = "Propriedade [direito_autoral] é obrigatório")]
      [StringLength(60, ErrorMessage = "Propriedade [direito_autoral] deve ter no máximo 60 caractere")]
      [JsonPropertyName("direito_autoral")]
      public string Direito_Autoral { get; set; }

      [Column("Perpectiva")]
      [Required(ErrorMessage = "Propriedade [perpectiva] é obrigatório")]
      [StringLength(25, ErrorMessage = "Propriedade [perpectiva] deve ter no máximo 25 caractere")]
      [JsonPropertyName("direito_autoral")]
      public string Perpectiva { get; set; }

      [Column("Engine")]
      [Required(ErrorMessage = "Propriedade [engine] é obrigatório")]
      [StringLength(10, ErrorMessage = "Propriedade [engine] deve ter no máximo 10 caractere")]
      [JsonPropertyName("engine")]
      public string Engine { get; set; }

      //[JsonPropertyName("Desenvolvedores")]
      // public virtual List<Desenvolvedor> Desenvolvedores { get; set; }
   }
}
