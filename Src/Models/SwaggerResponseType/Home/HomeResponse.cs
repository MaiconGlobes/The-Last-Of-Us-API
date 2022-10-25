using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home
{
   public class HomeRetornoOk
   {
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
      [JsonPropertyName("mensagem")]
      public string Mensagem { get; set; }
   }
}
