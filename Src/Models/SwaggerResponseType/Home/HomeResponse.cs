using Newtonsoft.Json;

namespace API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home
{
	public class HomeResponse
	{
		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("code_state")]
		public byte Code_State { get; set; }

		[JsonProperty("return")]
		public RetornoAtributoResponse Return { get; set; }
	}
}
