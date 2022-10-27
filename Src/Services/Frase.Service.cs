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

      public (byte Status, object Json) BuscarTodosRegistros()
      {
         try
         {
            var ListaDados = FFraseRepositories.BuscarTodosRegistros();

            if (ListaDados.Count > 0)
            {
               FObjJSON = ResponseUtils.Instancia().RetornoOk(ListaDados);
               return ((byte)EnumUtils.StatusProc.Sucesso, FObjJSON);
            }

            FObjJSON = ResponseUtils.Instancia().RetornoNotFound(ListaDados);
            return ((byte)EnumUtils.StatusProc.NaoLocalizado, FObjJSON);
         }
         catch
         {
            return ((byte)EnumUtils.StatusProc.ErroServidor, null);
         }
      }

      public (byte Status, object Json) BuscarTodosRegistrosPorPersonagem(string APersonagem)
      {
         try
         {
            APersonagem = APersonagem.ToLower();

            var ListaDados = FFraseRepositories.BuscarTodosRegistrosPorPersonagem(APersonagem);

            if ((ListaDados != null) & (ListaDados.Count > 0))
            {
               FObjJSON = ResponseUtils.Instancia().RetornoOk(ListaDados);
               return ((byte)EnumUtils.StatusProc.Sucesso, FObjJSON);
            }

            FObjJSON = ResponseUtils.Instancia().RetornoNotFound(ListaDados);
            return ((byte)EnumUtils.StatusProc.NaoLocalizado, FObjJSON);
         }
         catch
         {
            return ((byte)EnumUtils.StatusProc.ErroServidor, null);
         }
      }
   }
}
