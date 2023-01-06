using API_REST_The_Last_Of_Us.Src.Models.Dto;
using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType.Home;
using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_REST_The_Last_Of_Us.Controllers
{
  [ApiController]
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

    [HttpGet]
    public async Task<IActionResult> GetTodasFrasesAsync()
    {
      try
      {
        var (Status, Json) = await FFraseService.BuscarTodosRegistrosAsync();

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

    [HttpGet("{personagem}")]
    public async Task<IActionResult> GetFrasePorPersonagemAsync(string personagem)
    {
      try
      {
        var (Status, Json) = await FFraseService.BuscarRegistroPorPersonagemAsync(personagem);

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
    public async Task<IActionResult> PostFraseAsync([FromBody] FrasePOSTResponseDto AFraseBody)
    {
      try
      {
        FraseModel fraseModel = FMapper.Map<FraseModel>(AFraseBody);

        var (Status, Json) = await FFraseService.CriarRegistroAsync(fraseModel);

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
    public async Task<IActionResult> DeleteFrasePorId(int id)
    {
      try
      {
        var (Status, Json) = await FFraseService.DeletarRegistroAsync(id);

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
    public async Task<IActionResult> DeleteTodasFrasesAsync()
    {
      try
      {
        var Status = await FFraseService.DeletarTodosRegistrosAsync();

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
    }
  }
}
