using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
  [Table("Plataforma", Schema = "public")]
  public class PlataformaModel
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [Column("Versao")]
    [Required(ErrorMessage = "Propriedade [versao] é obrigatório")]
    [StringLength(20, ErrorMessage = "Propriedade [versao] deve ter no máximo 20 caractere")]
    [JsonPropertyName("versao")]
    public string Versao { get; set; }

    [Column("Console")]
    [Required(ErrorMessage = "Propriedade [console] é obrigatório")]
    [StringLength(20, ErrorMessage = "Propriedade [console] deve ter no máximo 20 caractere")]
    [JsonPropertyName("console")]
    public string Console { get; set; }

    [JsonIgnore]
    public Guid Sobre_id { get; set; }

    [JsonIgnore]
    public virtual SobreModel Sobre { get; set; }
  }
}
