using API_REST_The_Last_Of_Us.Src.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace API_REST_The_Last_Of_Us.Src.Services
{
  public class SobreRepositories
  {
    public Contexto FContexto { get; set; }

    public SobreRepositories()
    {
      FContexto = new Contexto();
    }
    public List<SobreModel> BuscarTodosRegistros()
    {
      return FContexto.SOBRE.OrderBy(sobre => sobre.Id).ToList();
    }
  }
}
