using API_REST_The_Last_Of_Us.Src.Services;
using API_REST_The_Last_Of_Us.Src.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_REST_The_Last_Of_Us.Controllers
{
  [ApiController]
  [Route("/sobre")]
  public class SobreController : ControllerBase
  {
    private SobreService FSobreService { get; set; }

    public SobreController()
    {
      FSobreService = new SobreService();
    }

    [HttpGet]
    public async Task<IActionResult> GetTodosRegistrosSobreAsync()
    {
      try
      {
        var (Status, Json) = await FSobreService.BuscarTodosRegistrosAsync();

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
