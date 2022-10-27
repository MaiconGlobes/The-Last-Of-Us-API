using API_REST_The_Last_Of_Us.Src.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace API_REST_The_Last_Of_Us.Src.Services
{
   public class FraseRepositories
   {
      public Contexto FContexto { get; set; }

      public FraseRepositories()
      {
         FContexto = new Contexto();
      }
      public List<FraseModel> BuscarTodosRegistros()
      {
         return FContexto.FRASE.OrderBy(frase => frase.Id).ToList();
      }
   }
}
