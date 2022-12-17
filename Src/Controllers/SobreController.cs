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
  [Route("/sobre")]
  public class SobreController : ControllerBase
  {
    private readonly IMapper FMapper;
    private SobreService FSobreService { get; set; }

    public SobreController(IMapper mapper)
    {
      FMapper = mapper;
      FSobreService = new SobreService();
    }

    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SobreRetornoOk))]
    [HttpGet]
    public IActionResult GetTodosRegistrosSobre()
    {
      try
      {
        var (Status, Json) = FSobreService.BuscarTodosRegistros();

        return Status switch
        {
          (byte)EnumUtils.StatusProc.Sucesso => new OkObjectResult(Json),
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
