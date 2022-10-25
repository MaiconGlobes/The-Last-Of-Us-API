using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using System.Collections.Generic;

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

      internal virtual object RetornoBoasVindasOk()
      {
         var response = new HomeResponse
         {
            State = "Sucess",
            Code_State = 200,
            Return = new ReturnAtributoHomeResponse
            {
               Message = "Welcome Developers"
            }
         };

         return response;
      }

      internal virtual object RetornoOk<T>(List<T> ADados)
      {
         FObjRetorno = new
         {
            retorno = new
            {
               dados = ADados
            }
         };

         return FObjRetorno;
      }
   }
}
