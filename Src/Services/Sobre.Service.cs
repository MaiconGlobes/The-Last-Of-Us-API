using API_REST_The_Last_Of_Us.Src.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class SobreService
   {
      public Contexto Fcontexto { get; set; }

      public SobreService()
      {
         Fcontexto = new Contexto();
      }
      public List<SobreModel> BuscarTodosRegistros()
      {
         return Fcontexto.SOBRE.OrderBy(sobre => sobre.Id).ToList();
      }
   }
}
