using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;

namespace API_REST_The_Last_Of_Us.Src.Utils
{
   public class ResponseUtils
   {
      private static ResponseUtils FInstancia { get; set; }
      private object FObjRetorno { get; set; }

      public static ResponseUtils Instancia()
      {
         if (FInstancia == null)
         {
            FInstancia = new ResponseUtils();
         }
         return FInstancia;
      }

      internal virtual HomeResponse RetornoOk()
      {
         var response = new HomeResponse
         {
            State = "Sucess",
            Code_State = 200,
            Return = new RetornoAtributoResponse
            {
               Message = "Welcome Developer"
            }
         };

         return response;
      }
   }
}
