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
		public int Id { get; set; }

		[Column("Descricao", TypeName = "Text")]
		[Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
		[JsonPropertyName("descricao")]
		public string Descricao { get; set; }

		[JsonIgnore]
		public int Personagem_id { get; set; }

		[JsonIgnore]
		public virtual PersonagemModel Personagem { get; set; }
	}
}
