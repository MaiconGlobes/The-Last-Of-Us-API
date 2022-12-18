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

    [Column("Tipo")]
    [Required(ErrorMessage = "Propriedade [tipo] é obrigatório")]
    [StringLength(25, ErrorMessage = "Propriedade [tipo] deve ter no máximo 25 caractere")]
    [JsonPropertyName("tipo")]
    public string Tipo { get; set; }

    [Column("Descricao", TypeName = "text")]
    [JsonPropertyName("descricao")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Propriedade [especie.personagens] é obrigatório")]
    [JsonIgnore]
    public virtual ICollection<PersonagemModel> Personagens { get; set; }

  }
}
