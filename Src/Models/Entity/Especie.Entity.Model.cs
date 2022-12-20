using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
  [Table("Especie", Schema = "public")]
  public class EspecieModel
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [Column("Definicao")]
    [Required(ErrorMessage = "Propriedade [definicao] é obrigatório")]
    [StringLength(25, ErrorMessage = "Propriedade [definicao] deve ter no máximo 25 caractere")]
    [JsonPropertyName("definicao")]
    public string Definicao { get; set; }

    [Required(ErrorMessage = "Propriedade [especie.personagens] é obrigatório")]
    [JsonIgnore]
    public virtual ICollection<GrupoModel> Grupo { get; set; }

  }
}
