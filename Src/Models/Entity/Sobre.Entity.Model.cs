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

      [JsonPropertyName("Desenvolvedores")]
      public virtual List<Desenvolvedor> Desenvolvedores { get; set; }
   }
}
