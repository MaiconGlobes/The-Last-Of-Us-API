using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Utils;
using System;
using System.Collections.Generic;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class FraseService
   {
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
               return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(ListaDados));
            }

            return ((byte)EnumUtils.StatusProc.NaoLocalizado, ResponseUtils.Instancia().RetornoNotFound(ListaDados));
         }
         catch
         {
            return ((byte)EnumUtils.StatusProc.ErroServidor, null);
         }
      }

      public (byte Status, object Json) BuscarRegistroPorPersonagem(string APersonagem)
      {
         try
         {
            APersonagem = APersonagem.ToLower();

            var ListaDados = FFraseRepositories.BuscarRegistroPorPersonagem(APersonagem);

            if ((ListaDados != null) & (ListaDados.Count > 0))
            {
               return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(ListaDados));
            }

            return ((byte)EnumUtils.StatusProc.NaoLocalizado, ResponseUtils.Instancia().RetornoNotFound(ListaDados));
         }
         catch
         {
            return ((byte)EnumUtils.StatusProc.ErroServidor, null);
         }
      }

      public (byte Status, object Json) CriarRegistro(FraseModel ADados)
      {
         try
         {
            var frase = ADados.Descricao.ToLower();

            var ListaDados = FFraseRepositories.BuscarRegistroFrase(frase);

            if ((ListaDados != null) & (ListaDados.Count == 0))
            {
               FraseModel registroCriado = FFraseRepositories.GravarRegistro(ADados);

               return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoCreated(registroCriado));
            }
            else
            if ((ListaDados != null) & (ListaDados.Count > 0))
            {
               return ((byte)EnumUtils.StatusProc.RegistroDuplicado, ResponseUtils.Instancia().RetornoDuplicated(ListaDados));
            }

            return ((byte)EnumUtils.StatusProc.ErroServidor, null);
         }
         catch
         {
            return ((byte)EnumUtils.StatusProc.ErroServidor, null);
         }
      }
   }
}
