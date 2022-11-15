using API_REST_The_Last_Of_Us.Src.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.Dto
{
    public class SobreResponseDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("missao")]
        public string Missao { get; set; }

        [JsonPropertyName("desenvolvedor")]
        public string Desenvolvedor { get; set; }

        [JsonPropertyName("escritor")]
        public string Escritor { get; set; }

        [JsonPropertyName("compositor")]
        public string Compositor { get; set; }

        [JsonPropertyName("direito_autoral")]
        public string Direito_Autoral { get; set; }

        [JsonPropertyName("genero")]
        public string Genero { get; set; }

        [JsonPropertyName("perpectiva")]
        public string Perpectiva { get; set; }

        [JsonPropertyName("engine")]
        public string Engine { get; set; }

        [JsonPropertyName("classificacao")]
        public string Classificacao { get; set; }

        [JsonPropertyName("lancamentos")]
        public virtual List<LancamentoModel> Lancamentos { get; set; }

        [JsonPropertyName("designers")]
        public virtual List<DesignerModel> Designers { get; set; }

        [JsonPropertyName("plataformas")]
        public virtual List<PlataformaModel> Plataformas { get; set; }

        [JsonPropertyName("sinopse")]
        public string Sinopse { get; set; }
    }
}
