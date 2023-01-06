using API_REST_The_Last_Of_Us.Src.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_The_Last_Of_Us.Src.Services
{
  public class PersonagemRepositories
  {
    public Contexto FContexto { get; set; }

    public PersonagemRepositories()
    {
      FContexto = new Contexto();
    }

    public List<PersonagemModel> BuscarRegistroPersonagem(string APersonagem)
    {
      return FContexto.PERSONAGEM.OrderBy(personagem => personagem.Id).Where(personagem => personagem.Nome.ToLower().Contains(APersonagem)).ToList();
    }

    /*    public List<PersonagemModel> BuscarRegistroPorId(int AId)
        {
          return FContexto.Personagem.Where(personagem => personagem.Id == AId).ToList();
        }
    */
    public async Task<IEnumerable> BuscarTodosRegistros()
    {
      return await FContexto.PERSONAGEM.OrderBy(grupo => grupo.Grupo_id)
        .Join(FContexto.GRUPO,
          personagem => personagem.Grupo_id,
          personagem => personagem.Id,
          (personagem, grupo) =>
          new
          {
            id = personagem.Id,
            nome = personagem.Nome,
            grupo = new
            {
              id = personagem.Grupo_id,
              tipo = grupo.Tipo
            }
          })
        .ToListAsync();
    }
    /*
    public async Task<IEnumerable> BuscarRegistroPorPersonagemAsync(string APersonagem)
    {
      return await FContexto.Personagem.OrderBy(Personagem => Personagem.Id)
        .Join(FContexto.PERSONAGEM,
          Personagem => Personagem.Personagem_id,
          personagem => personagem.Id,
          (Personagem, personagem) =>
          new
          {
            Personagem.Id,
            Personagem.Descricao,
            Personagem.Personagem_id,
            personagem_nome = personagem.Nome,
          })
        .Where(personagem => personagem.personagem_nome.ToLower().Contains(APersonagem))
        .ToListAsync();
    }

    public async Task<PersonagemModel> GravarRegistroAsync(PersonagemModel ADados)
    {
      FContexto.Personagem.Add(ADados);
      await FContexto.SaveChangesAsync();
      return ADados;
    }

    public async Task<PersonagemModel> DeletarRegistro(PersonagemModel ADados)
    {
      FContexto.Personagem.Remove(ADados);
      await FContexto.SaveChangesAsync();
      return ADados;
    }

    public async Task DeletarTodosRegistrosAsync(DbSet<PersonagemModel> ADados)
    {
      FContexto.Personagem.RemoveRange(ADados);
      await FContexto.SaveChangesAsync();
    }*/
  }
}
