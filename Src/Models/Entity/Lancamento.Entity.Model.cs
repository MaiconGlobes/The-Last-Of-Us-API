using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
   [Table("Lancamento", Schema = "public")]
   public class LancamentoModel
   {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [JsonPropertyName("id")]
      public Guid Id { get; set; }

      [Column("Versao")]
      [Required(ErrorMessage = "Propriedade [Versao] é obrigatório")]
      [StringLength(20, ErrorMessage = "Propriedade [nome] deve ter no máximo 20 caractere")]
      [JsonPropertyName("versao")]
      public string Versao { get; set; }

      [Column("Data", TypeName = "date")]
      [Required(ErrorMessage = "Propriedade [data] é obrigatório")]
      [JsonPropertyName("data")]
      public DateTime Data { get; set; }

      [JsonIgnore]
      public Guid Sobre_id { get; set; }

      [JsonIgnore]
      public virtual SobreModel Sobre { get; set; }
   }
}
