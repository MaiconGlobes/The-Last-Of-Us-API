using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_REST_The_Last_Of_Us.Controllers
{
  [ApiController]
  [Route("/personagem")]
  public class PersonagemController : ControllerBase
  {
    private readonly IMapper FMapper;
    private PersonagemService FPersonagemService { get; set; }

    public PersonagemController(IMapper mapper)
    {
      FMapper = mapper;
      FPersonagemService = new PersonagemService();
    }

    [HttpGet]
    public async Task<IActionResult> GetTodosPersonagensAsync()
    {
      try
      {
        var (Status, Json) = await FPersonagemService.BuscarTodosRegistrosAsync();

        return Status switch
        {
          (byte)EnumUtils.StatusProc.Sucesso => new OkObjectResult(Json),
          (byte)EnumUtils.StatusProc.SemRegistros => new OkObjectResult(Json),
          (byte)EnumUtils.StatusProc.ErroServidor => throw new System.NotImplementedException(),
          _ => throw new System.NotImplementedException()
        };
      }
      catch
      {
        return new StatusCodeResult(StatusCodes.Status500InternalServerError);
      }
    }
    /*
        [HttpGet("{personagem}")]
        public async Task<IActionResult> GetPersonagemPorPersonagemAsync(string personagem)
        {
          try
          {
            var (Status, Json) = await FPersonagemService.BuscarRegistroPorPersonagemAsync(personagem);

            return Status switch
            {
              (byte)EnumUtils.StatusProc.Sucesso => new OkObjectResult(Json),
              (byte)EnumUtils.StatusProc.SemRegistros => new OkObjectResult(Json),
              (byte)EnumUtils.StatusProc.ErroServidor => throw new System.NotImplementedException(),
              _ => throw new System.NotImplementedException()
            };
          }
          catch
          {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
          }
        }

        [HttpPost]
        public async Task<IActionResult> PostPersonagemAsync([FromBody] FrasePOSTResponseDto AFraseBody)
        {
          try
          {
            FraseModel fraseModel = FMapper.Map<FraseModel>(AFraseBody);

            var (Status, Json) = await FPersonagemService.CriarRegistroAsync(fraseModel);

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonagemPorId(int id)
        {
          try
          {
            var (Status, Json) = await FPersonagemService.DeletarRegistroAsync(id);

            return Status switch
            {
              (byte)EnumUtils.StatusProc.Sucesso => new NoContentResult(),
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

        [HttpDelete]
        public async Task<IActionResult> DeleteTodosPersonagensAsync()
        {
          try
          {
            var Status = await FPersonagemService.DeletarTodosRegistrosAsync();

            return Status switch
            {
              (byte)EnumUtils.StatusProc.Sucesso => new NoContentResult(),
              (byte)EnumUtils.StatusProc.ErroServidor => throw new System.NotImplementedException(),
              _ => throw new System.NotImplementedException()
            };
          }
          catch
          {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
          }
        }*/
  }
}
