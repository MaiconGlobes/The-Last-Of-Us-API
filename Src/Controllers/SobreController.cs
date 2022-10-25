using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SobreRetornoOk))]
   [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(SobreRetornoBadRequest))]   
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [Route("/sobre")]
   public class SobreController : ControllerBase
   {
      private object FObjRetorno { get; set; }
      private SobreService FSobreService { get; set; }

      public SobreController()
      {
         FSobreService = new SobreService();
      }

      [HttpGet]
      public IActionResult GetTodosRegistrosSobre()
      {
         try
         {
            FObjRetorno = FSobreService.BuscarTodosRegistros();

            var teste = ResponseUtils.Instancia().RetornoOk(FObjRetorno);
            return new OkObjectResult(teste);
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }
   }
}
