using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Dto
{
  public class FraseGETResponseDto
  {
    [JsonPropertyName("descricao")]
    public string Descricao { get; set; }

    [JsonPropertyName("personagem_id")]
    public Guid Personagem_id { get; set; }

    [JsonPropertyName("personagem_nome")]
    public string Personagem_nome { get; set; }
  }

  public class FrasePOSTResponseDto
  {
    [Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
    [StringLength(5000, MinimumLength = 3, ErrorMessage = "Propriedade [descricao] deve ter no mínimo 3 e no máximo 5000 caractere")]
    [JsonPropertyName("descricao")]
    public string Descricao { get; set; }

    [JsonPropertyName("personagem_id")]
    public Guid Personagem_id { get; set; }
  }
}
