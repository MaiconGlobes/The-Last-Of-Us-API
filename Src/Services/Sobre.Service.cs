using API_REST_The_Last_Of_Us.Src.Utils;
using System;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class SobreService
   {
      public Object FRetorno { get; set; }
      public Contexto Fcontexto { get; set; }
      private SobreRepositories FobreRepositories { get; set; }

      public SobreService()
      {
         Fcontexto = new Contexto();
         FobreRepositories = new SobreRepositories();
      }

      public (int Status, object Json) ProcessarBuscaRegistro()
      {
         try
         {
            var ListaDados = FobreRepositories.BuscarTodosRegistros();

            FRetorno = ResponseUtils.Instancia().RetornoOk(ListaDados);

            return new ValueTuple<int, object>(1, FRetorno);
         }
         catch
         {
            return new ValueTuple<int, object>(-1, null);
         }
      }
   }
}
