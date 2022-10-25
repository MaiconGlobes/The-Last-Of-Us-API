using Newtonsoft.Json;

namespace API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home
{
   public class HomeResponse
   {
      [JsonProperty("status")]
      public string Status { get; set; }

      [JsonProperty("codigo_Status")]
      public byte Codigo_Status { get; set; }

      [JsonProperty("retorno")]
      public ReturnAtributoHomeResponse Retorno { get; set; }
   }
}
