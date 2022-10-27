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
      public List<FraseModel> BuscarRegistroFrase(string AFrase)
      {
         return FContexto.FRASE.OrderBy(frase => frase.Id).Where(personagem => personagem.Descricao.ToLower().Contains(AFrase)).ToList();
      }

      public List<FraseModel> BuscarRegistroPorPersonagem(string APersonagem)
      {
         return FContexto.FRASE.OrderBy(frase => frase.Id).Where(personagem => personagem.Personagem.ToLower().Contains(APersonagem)).ToList();
      }

      public FraseModel GravarRegistro(FraseModel ADados)
      {
         FContexto.FRASE.Add(ADados);
         FContexto.SaveChanges();

         return ADados;
      }
   }
}
