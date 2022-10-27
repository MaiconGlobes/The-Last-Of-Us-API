using API_REST_The_Last_Of_Us.Src.Utils;
using System;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class FraseService
   {
      public Object FObjJSON { get; set; }
      public Contexto Fcontexto { get; set; }
      private FraseRepositories FFraseRepositories { get; set; }

      public FraseService()
      {
         Fcontexto = new Contexto();
         FFraseRepositories = new FraseRepositories();
      }

      public (byte Status, Object Json) ProcessarBuscaRegistro()
      {
         try
         {
            var ListaDados = FFraseRepositories.BuscarTodosRegistros();

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
