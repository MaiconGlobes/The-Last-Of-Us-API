using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Sobre))]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [Route("/sobre")]
   public class SobreController : ControllerBase
   {
      private object FObjRetorno { get; set; }
      public Contexto Fcontexto { get; set; }

      public SobreController()
      {
         Fcontexto = new Contexto();
      }

      [HttpGet]
      public IActionResult BoasVindas()
      {
         try
         {
            FObjRetorno = Fcontexto.SOBRE.FirstOrDefault();
            return new OkObjectResult(FObjRetorno);
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }
   }
}
