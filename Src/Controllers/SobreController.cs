﻿using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [Route("/sobre")]
   public class SobreController : ControllerBase
   {
      private readonly IMapper FMapper;

      private SobreService FSobreService { get; set; }
      private SobreRetornoOk FObjRetornoOk { get; set; }

      public SobreController(IMapper mapper)
      {
         FMapper = mapper;
         FSobreService = new SobreService();
      }

      [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SobreRetornoOk))]
      [HttpGet]
      public IActionResult GetTodosRegistrosSobre()
      {
         try
         {
            var (Status, Json) = FSobreService.ProcessarBuscaRegistro();

            return (Status) switch
            {
               (int)EnumUtils.StatusProc.Sucesso => new OkObjectResult(Json),
               (int)EnumUtils.StatusProc.ErroServidor => null,
               _ => throw new System.NotImplementedException()
            };
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }
   }
}
