using System;
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

      [Column("titulo")]
      [Required(ErrorMessage = "Propriedade [titulo] é obrigatório")]
      [StringLength(14, ErrorMessage = "Propriedade [titulo] deve ter no máximo 14 caractere")]
      [JsonPropertyName("titulo")]
      public string Titulo { get; set; }

      [Column("descricao", TypeName = "text")]
      [Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
      [JsonPropertyName("descricao")]
      public string Descricao { get; set; }
   }
}
