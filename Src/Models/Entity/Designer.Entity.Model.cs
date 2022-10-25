using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
   [Table("Designer", Schema = "public")]
   public class DesignerModel
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [JsonPropertyName("id")]
      public Guid Id { get; set; }

      [Column("Nome")]
      [Required(ErrorMessage = "Propriedade [nome] é obrigatório")]
      [StringLength(25, ErrorMessage = "Propriedade [nome] deve ter no máximo 25 caractere")]
      [JsonPropertyName("nome")]
      public string Nome { get; set; }

      [Column("Perfil")]
      [Required(ErrorMessage = "Propriedade [perfil] é obrigatório")]
      [StringLength(255, ErrorMessage = "Propriedade [perfil] deve ter no máximo 255 caractere")]
      [JsonPropertyName("perfil")]
      public string Perfil { get; set; }

      [JsonIgnore]
      public Guid Sobre_id { get; set; }

      [JsonIgnore]
      public virtual SobreModel Sobre { get; set; }
   }
}
