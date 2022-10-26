using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class SobreService
   {
      public Contexto Fcontexto { get; set; }
      private SobreRepositories FobreRepositories { get; set; }

      public SobreService()
      {
         Fcontexto = new Contexto();
         FobreRepositories = new SobreRepositories();
      }
      public SobreRetornoOk ProcessarBuscaRegistro()
      {
         try
         {
            var ListaDados = FobreRepositories.BuscarTodosRegistros();

            return ResponseUtils.Instancia().RetornoOk(ListaDados) as SobreRetornoOk;
         }
         catch
         {
            return null;
         }
      }
   }
}
