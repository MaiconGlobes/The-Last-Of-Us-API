using API_REST_The_Last_Of_Us.Src.Utils;
using System.Threading.Tasks;

namespace API_REST_The_Last_Of_Us.Src.Services
{
  public class SobreService
  {
    public Contexto Fcontexto { get; set; }
    private SobreRepositories FSobreRepositories { get; set; }

    public SobreService()
    {
      Fcontexto = new Contexto();
      FSobreRepositories = new SobreRepositories();
    }

    public async Task<(byte Status, object Json)> BuscarTodosRegistrosAsync()
    {
      try
      {
        var listaDados = await FSobreRepositories.BuscarTodosRegistrosAsync();

        return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(listaDados));
      }
      catch
      {
        return ((byte)EnumUtils.StatusProc.ErroServidor, null);
      }
    }
  }
}
