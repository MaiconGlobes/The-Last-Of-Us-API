using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Entity
{
	[Table("Versao", Schema = "public")]
	public class VersaoModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[Column("Versao")]
		[Required(ErrorMessage = "Propriedade [descricao] é obrigatório")]
		[StringLength(50, ErrorMessage = "Propriedade [descricao] deve ter no máximo 50 caractere")]
		[JsonPropertyName("descricao")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "Propriedade [versao.idades] é obrigatório")]
		[JsonPropertyName("idades")]
		public virtual ICollection<IdadeModel> Idades { get; set; }

		[JsonIgnore]
		public Guid Sobre_id { get; set; }

		[JsonIgnore]
		public virtual SobreModel Sobre { get; set; }
	}
}
