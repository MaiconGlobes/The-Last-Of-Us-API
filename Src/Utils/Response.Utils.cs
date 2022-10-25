using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using AutoMapper;
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
            Status = "Sucesso",
            Codigo_Status = 200,
            Retorno = new ReturnAtributoHomeResponse
            {
               Message = "Welcome Developers"
            }
         };

         return response;
      }

      internal virtual object RetornoOk<T>( List<T> ADados)
      {
         FObjRetorno = new
         {
            retorno = new
            {
               status = "Sucesso",
               codigo_status = 1,
               dados = ADados
            }
         };

         return FObjRetorno;
      }

      internal virtual object RetornoOk(object ADados)
      {
         FObjRetorno = new
         {
            retorno = new
            {
               status = "Sucesso",
               codigo_status = 1,
               dados = ADados
            }
         };

         return FObjRetorno;
      }
}
}
