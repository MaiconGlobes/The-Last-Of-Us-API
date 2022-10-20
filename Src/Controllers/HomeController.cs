using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HomeResponse))]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [Route("home")]
   public class HomeController : ControllerBase
   {
      [HttpGet]
      public IActionResult BoasVindas()
      {
         var response = new HomeResponse
         {
            State = "Sucess",
            Code_State = 200,
            Return = new RetornoAtributoResponse
            {
               Message = "Welcome Developer"
            }
         };

         return new OkObjectResult(response);
      }
   }
}
