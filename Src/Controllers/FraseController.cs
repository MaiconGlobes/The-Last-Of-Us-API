using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_The_Last_Of_Us.Controllers
{
   [ApiController]
   [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
      [HttpGet]
      public IActionResult GetTodasFrase()
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
      [HttpGet("{personagem}")]
      public IActionResult GetFrasePorPersonagem(string personagem)
      {
         try
         {
            var (Status, Json) = FFraseService.BuscarRegistroPorPersonagem(personagem);

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

      [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(FraseRetornoOk))]
      [HttpPost]
      public IActionResult PostFrase([FromBody] FraseResponseDto AFraseBody)
      {
         try
         {
            FraseModel fraseModel = FMapper.Map<FraseModel>(AFraseBody);

            var (Status, Json) = FFraseService.CriarRegistro(fraseModel);

            return Status switch
            {
               (byte)EnumUtils.StatusProc.Sucesso => new CreatedResult(nameof(FraseRetornoOk), Json),
               (byte)EnumUtils.StatusProc.RegistroDuplicado => new ConflictObjectResult(Json),
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
