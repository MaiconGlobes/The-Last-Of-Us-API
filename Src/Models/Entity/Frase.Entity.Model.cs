using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
	[Table("Frase", Schema = "public")]
	public class FraseModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[JsonPropertyName("id")]
		public Guid Id { get; set; }

		[Column("Descricao", TypeName = "Text")]
		[Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
		[JsonPropertyName("descricao")]
		public string Descricao { get; set; }

		[Column("Personagem")]
		[Required(ErrorMessage = "Propriedade [personagem] é obrigatório")]
		[StringLength(60, ErrorMessage = "Propriedade [personagem] deve ter no máximo 60 caractere")]
		[JsonPropertyName("personagem")]
		public string Personagem { get; set; }
	}
}
