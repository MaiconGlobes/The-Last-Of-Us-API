using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
   [Table("Desenvolvedor", Schema = "public")]
   public class Desenvolvedor
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [JsonPropertyName("id")]
      public Guid Id { get; set; }

      [Column("Nome")]
      [Required(ErrorMessage = "Propriedade [nome] é obrigatório")]
      [StringLength(80, ErrorMessage = "Propriedade [nome] deve ter no máximo 80 caractere")]
      [JsonPropertyName("nome")]
      public string Nome { get; set; }

      [JsonIgnore]
      public Guid Sobre_id { get; set; }

      [JsonIgnore]
      public virtual Sobre Sobre { get; set; }
   }
}
