﻿using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HomeRetornoOk))]
   [ProducesResponseType(StatusCodes.Status500InternalServerError)]
   [Produces("application/json")]
   [Route("/home")]
   public class HomeController : ControllerBase
   {
      private object FObjRetorno { get; set; }

      [HttpGet]
      public IActionResult BoasVindas()
      {
         try
         {
            FObjRetorno = ResponseUtils.Instancia().RetornoBoasVindasOk();
            return new OkObjectResult(FObjRetorno);
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }
   }
}
