using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SobreModel))]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
            return new OkObjectResult(FObjRetorno);
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }
   }
}
