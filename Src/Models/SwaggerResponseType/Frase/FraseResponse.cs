using API_REST_The_Last_Of_Us.Src.Models.Dto;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home
{
    public class FraseRetornoOk
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("codigo_Status")]
        public byte Codigo_Status { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("dados")]
        public List<FraseResponseDto> Dados { get; set; }
    }
}
