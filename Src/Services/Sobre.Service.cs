using API_REST_The_Last_Of_Us.Src.Utils;
using System;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class SobreService
   {
      public Object FObjJSON { get; set; }
      public Contexto Fcontexto { get; set; }
      private SobreRepositories FSobreRepositories { get; set; }

      public SobreService()
      {
         Fcontexto = new Contexto();
         FSobreRepositories = new SobreRepositories();
      }

      public (byte Status, object Json) BuscarTodosRegistros()
      {
         try
         {
            var ListaDados = FSobreRepositories.BuscarTodosRegistros();

            FObjJSON = ResponseUtils.Instancia().RetornoOk(ListaDados);

            return ((byte)EnumUtils.StatusProc.Sucesso, FObjJSON);
         }
         catch
         {
            return ((byte)EnumUtils.StatusProc.ErroServidor, null);
         }
      }
   }
}
