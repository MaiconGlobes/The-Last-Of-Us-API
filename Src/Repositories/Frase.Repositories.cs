using API_REST_The_Last_Of_Us.Src.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_The_Last_Of_Us.Src.Services
{
  public class FraseRepositories
  {
    public Contexto FContexto { get; set; }

    public FraseRepositories()
    {
      FContexto = new Contexto();
    }

    public List<FraseModel> BuscarRegistroFrase(string AFrase)
    {
      return FContexto.FRASE.OrderBy(frase => frase.Id).Where(personagem => personagem.Descricao.ToLower().Contains(AFrase)).ToList();
    }

    public List<FraseModel> BuscarRegistroPorId(int AId)
    {
      return FContexto.FRASE.Where(personagem => personagem.Id == AId).ToList();
    }

    public async Task<IEnumerable> BuscarTodosRegistros()
    {
      return await FContexto.FRASE.OrderBy(frase => frase.Id)
        .Join(FContexto.PERSONAGEM,
          frase => frase.Personagem_id,
          personagem => personagem.Id,
          (frase, personagem) =>
          new
          {
            frase.Id,
            frase.Descricao,
            frase.Personagem_id,
            personagem_nome = personagem.Nome,
          })
        .ToListAsync();
    }

    public async Task<IEnumerable> BuscarRegistroPorPersonagemAsync(string APersonagem)
    {
      return await FContexto.FRASE.OrderBy(frase => frase.Id)
        .Join(FContexto.PERSONAGEM,
          frase => frase.Personagem_id,
          personagem => personagem.Id,
          (frase, personagem) =>
          new
          {
            frase.Id,
            frase.Descricao,
            frase.Personagem_id,
            personagem_nome = personagem.Nome,
          })
        .Where(personagem => personagem.personagem_nome.ToLower().Contains(APersonagem))
        .ToListAsync();
    }

    public async Task<FraseModel> GravarRegistroAsync(FraseModel ADados)
    {
      FContexto.FRASE.Add(ADados);
      await FContexto.SaveChangesAsync();
      return ADados;
    }

    public async Task<FraseModel> DeletarRegistro(FraseModel ADados)
    {
      FContexto.FRASE.Remove(ADados);
      await FContexto.SaveChangesAsync();
      return ADados;
    }

    public async Task DeletarTodosRegistrosAsync(DbSet<FraseModel> ADados)
    {
      FContexto.FRASE.RemoveRange(ADados);
      await FContexto.SaveChangesAsync();
    }
  }
}
