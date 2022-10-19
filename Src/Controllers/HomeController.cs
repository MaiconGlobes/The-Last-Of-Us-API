using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [ApiController]
   [Route("home")]
   public class HomeController : ControllerBase
   {
      [HttpGet]
      public IActionResult BoasVindas()
      {
         object Retorno = new
         {
            boas_vindas = "Welcome Developer",
         };

         return new OkObjectResult(Retorno);
      }
   }
}
