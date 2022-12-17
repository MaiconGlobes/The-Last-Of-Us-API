using API_REST_The_Last_Of_Us.Src.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_The_Last_Of_Us.Src.Services
{
  public class SobreRepositories
  {
    public Contexto FContexto { get; set; }

    public SobreRepositories()
    {
      FContexto = new Contexto();
    }
    public async Task<List<SobreModel>> BuscarTodosRegistrosAsync()
    {
      return await FContexto.SOBRE.OrderBy(sobre => sobre.Id).ToListAsync();
    }
  }
}
