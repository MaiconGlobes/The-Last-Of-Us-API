using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home
{
   public class ReturnAtributoHomeResponse
   {
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
      [JsonPropertyName("mensagem")]
      public string Message { get; set; }
   }
}
