using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
  [Table("Grupo", Schema = "public")]
  public class GrupoModel
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [Column("Tipo")]
    [Required(ErrorMessage = "Propriedade [tipo] é obrigatório")]
    [StringLength(25, ErrorMessage = "Propriedade [titulo] deve ter no máximo 25 caractere")]
    [JsonPropertyName("tipo")]
    public string Tipo { get; set; }

    [Column("Detalhe", TypeName = "text")]
    [JsonPropertyName("definicao")]
    public string Definicao { get; set; }

    [JsonIgnore]
    public int Especie_id { get; set; }

    [JsonIgnore]
    public virtual EspecieModel Especie { get; set; }

    [Required(ErrorMessage = "Propriedade [especie.personagem] é obrigatório")]
    [JsonIgnore]
    public virtual ICollection<PersonagemModel> Personagem { get; set; }

  }
}
