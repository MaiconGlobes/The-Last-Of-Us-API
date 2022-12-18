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

    [Column("Descricao")]
    [Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
    [StringLength(25, ErrorMessage = "Propriedade [descricao] deve ter no máximo 25 caractere")]
    [JsonPropertyName("descricao")]
    public string Descricao { get; set; }

    [Column("Detalhe", TypeName = "text")]
    [JsonPropertyName("detalhe")]
    public string Detalhe { get; set; }

    [Required(ErrorMessage = "Propriedade [especie.personagens] é obrigatório")]
    [JsonIgnore]
    public virtual ICollection<PersonagemModel> Personagem { get; set; }

  }
}
