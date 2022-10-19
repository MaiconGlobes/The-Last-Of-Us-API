using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class HomeController : ControllerBase
   {
      [HttpGet]
      public IActionResult Get()
      {
         return new OkResult();
      }
   }
}
