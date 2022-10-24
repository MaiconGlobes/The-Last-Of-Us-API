using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
   [Table("Genero", Schema = "public")]
   public class GeneroModel
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [JsonPropertyName("id")]
      public Guid Id { get; set; }

      [Column("Descricao")]
      [Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
      [StringLength(25, ErrorMessage = "Propriedade [descricao] deve ter no máximo 25 caractere")]
      [JsonPropertyName("descricao")]
      public string Descricao { get; set; }

      [JsonIgnore]
      public Guid Sobre_id { get; set; }

      [JsonIgnore]
      public virtual SobreModel Sobre { get; set; }
   }
}
