using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
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
   [Route("/frase")]
   public class FraseController : ControllerBase
   {
      private readonly IMapper FMapper;
      private FraseService FFraseService { get; set; }

      public FraseController(IMapper mapper)
      {
         FMapper = mapper;
         FFraseService = new FraseService();
      }

      [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FraseRetornoOk))]
      [ProducesResponseType(StatusCodes.Status400BadRequest)]
      [HttpGet]
      public IActionResult GetFrase()
      {
         try
         {
            var (Status, Json) = FFraseService.BuscarTodosRegistros();

            return Status switch
            {
               (byte)EnumUtils.StatusProc.Sucesso => new OkObjectResult(Json),
               (byte)EnumUtils.StatusProc.NaoLocalizado => new OkObjectResult(Json),
               (byte)EnumUtils.StatusProc.ErroServidor => throw new System.NotImplementedException(),
               _ => throw new System.NotImplementedException()
            };
         }
         catch
         {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
         }
      }

      [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FraseRetornoOk))]
      [ProducesResponseType(StatusCodes.Status400BadRequest)]
      [HttpGet("{personagem}")]
      public IActionResult GetFrasePorPersonagem(string personagem)
      {
         try
         {
            var (Status, Json) = FFraseService.BuscarTodosRegistrosPorPersonagem(personagem);

            return Status switch
            {
               (byte)EnumUtils.StatusProc.Sucesso => new OkObjectResult(Json),
               (byte)EnumUtils.StatusProc.NaoLocalizado => new OkObjectResult(Json),
               (byte)EnumUtils.StatusProc.ErroServidor => throw new System.NotImplementedException(),
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
