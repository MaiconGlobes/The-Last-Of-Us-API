using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
	[Table("Idade", Schema = "public")]
	public class IdadeModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[Column("Idade")]
		[Required(ErrorMessage = "Propriedade [idade] é obrigatório")]
		[JsonPropertyName("idade")]
		public int Idade { get; set; }

		[JsonIgnore]
		public int Versao_id { get; set; }

		[JsonIgnore]
		public virtual VersaoModel Versao { get; set; }

		[JsonIgnore]
		public int Personagem_id { get; set; }

		[JsonIgnore]
		public virtual PersonagemModel Personagem { get; set; }
	}
}
