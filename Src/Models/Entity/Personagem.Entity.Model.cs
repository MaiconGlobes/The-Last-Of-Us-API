using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
  [Table("Personagem", Schema = "public")]
  public class PersonagemModel
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [Column("Nome")]
    [Required(ErrorMessage = "Propriedade [nome] é obrigatório")]
    [StringLength(35, ErrorMessage = "Propriedade [nome] deve ter no máximo 35 caractere")]
    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Propriedade [personagem.frases] é obrigatório")]
    [JsonPropertyName("frases")]
    public virtual ICollection<FraseModel> Frases { get; set; }

    [Required(ErrorMessage = "Propriedade [personagem.idades] é obrigatório")]
    [JsonPropertyName("idades")]
    public virtual ICollection<IdadeModel> Idades { get; set; }

  }
}
