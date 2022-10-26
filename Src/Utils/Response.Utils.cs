using System;
using System.Collections.Generic;

namespace API_REST_The_Last_Of_Us.Src.Utils
{
   public class ResponseUtils
   {
      private static ResponseUtils FInstancia { get; set; }
      private object FObjJSON { get; set; }

      public static ResponseUtils Instancia()
      {
         FInstancia ??= new ResponseUtils();
         return FInstancia;
      }

      internal virtual object RetornoBoasVindasOk()
      {
         FObjJSON = new
         {
               mensagem = "Não importa o que aconteça, você continua encontrando algo pelo qual lutar. Ellie"
         };

         return FObjJSON;
      }

      internal virtual Object RetornoOk(Object ADados)
      {
         FObjJSON = new
         {
            retorno = new
            {
               status = "Sucesso",
               codigo_status = EnumUtils.StatusProc.Sucesso,
               dados = ADados
            }
         };

         return FObjJSON;
      }

      internal virtual object RetornoOk<T>(List<T> ADados)
      {
         FObjJSON = new
         {
            retorno = new
            {
               status = "Sucesso",
               codigo_status = EnumUtils.StatusProc.Sucesso,
               dados = ADados
            }
         };

         return FObjJSON;
      }
   }
}
