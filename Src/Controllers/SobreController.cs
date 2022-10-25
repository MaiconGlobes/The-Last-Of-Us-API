using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   //[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(SobreRetornoBadRequest))]   
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [Route("/sobre")]
   public class SobreController : ControllerBase
   {
      private readonly IMapper FMapper;

      private object FObjDados { get; set; }
      private SobreService FSobreService { get; set; }

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

            var ObjDados = FSobreService.BuscarTodosRegistros();


            var teste = ResponseUtils.Instancia().RetornoOk(ObjDados);

            return new OkObjectResult(teste);
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }
   }
}
