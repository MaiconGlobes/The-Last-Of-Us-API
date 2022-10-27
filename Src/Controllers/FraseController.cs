using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FraseRetornoOk))]
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [Route("/frase")]
   public class FraseController : ControllerBase
   {
      private object FObjRetorno { get; set; }

      [HttpGet]
      public IActionResult GetFrase()
      {
         try
         {
            FObjRetorno = ResponseUtils.Instancia().FrasesAleatorias();
            return new OkObjectResult(FObjRetorno);
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }
   }
}
