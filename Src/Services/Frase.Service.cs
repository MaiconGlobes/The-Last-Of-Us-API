using API_REST_The_Last_Of_Us.Src.Models.Entity;
using API_REST_The_Last_Of_Us.Src.Utils;
using Castle.Core.Internal;

namespace API_REST_The_Last_Of_Us.Src.Services
{
  public class FraseService
  {
    public Contexto Fcontexto { get; set; }
    private FraseRepositories FFraseRepositories { get; set; }

    public FraseService()
    {
      Fcontexto = new Contexto();
      FFraseRepositories = new FraseRepositories();
    }

    public (byte Status, object Json) BuscarTodosRegistros()
    {
      try
      {
        var listaDados = FFraseRepositories.BuscarTodosRegistros();

        if ((listaDados != null) && (!listaDados.IsNullOrEmpty()))
        {
          return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(listaDados));
        }

        return ((byte)EnumUtils.StatusProc.SemRegistros, ResponseUtils.Instancia().RetornoNotFound(listaDados));
      }
      catch
      {
        return ((byte)EnumUtils.StatusProc.ErroServidor, null);
      }
    }

    public (byte Status, object Json) BuscarRegistroPorPersonagem(string APersonagem)
    {
      try
      {
        APersonagem = APersonagem.ToLower();

        var listaDados = FFraseRepositories.BuscarRegistroPorPersonagem(APersonagem);

        if ((listaDados != null) && (!listaDados.IsNullOrEmpty()))
        {
          return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(listaDados));
        }

        return ((byte)EnumUtils.StatusProc.SemRegistros, ResponseUtils.Instancia().RetornoNotFound(listaDados));
      }
      catch
      {
        return ((byte)EnumUtils.StatusProc.ErroServidor, null);
      }
    }

    public (byte Status, object Json) CriarRegistro(FraseModel ADados)
    {
      try
      {
        var frase = ADados.Descricao.ToLower();

        var listaDados = FFraseRepositories.BuscarRegistroFrase(frase);

        if ((listaDados != null) & (listaDados.Count == 0))
        {
          FraseModel registroCriado = FFraseRepositories.GravarRegistro(ADados);

          return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoCreated(registroCriado));
        }
        else
        if ((listaDados != null) & (listaDados.Count > 0))
        {
          return ((byte)EnumUtils.StatusProc.RegistroDuplicado, ResponseUtils.Instancia().RetornoDuplicated(listaDados));
        }

        return ((byte)EnumUtils.StatusProc.ErroServidor, null);
      }
      catch
      {
        return ((byte)EnumUtils.StatusProc.ErroServidor, null);
      }
    }

    public (byte Status, object Json) DeletarRegistro(int AId)
    {
      try
      {
        var listaDados = FFraseRepositories.BuscarRegistroPorId(AId);

        if ((listaDados != null) & (listaDados.Count > 0))
        {
          FraseModel registroDeletado = FFraseRepositories.DeletarRegistro(listaDados[0]);

          return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(listaDados));
        }

        return ((byte)EnumUtils.StatusProc.NaoLocalizado, ResponseUtils.Instancia().RetornoNotAcceptable(listaDados));
      }
      catch
      {
        return ((byte)EnumUtils.StatusProc.ErroServidor, null);
      }
    }

    public byte DeletarTodosRegistros()
    {
      try
      {
        FFraseRepositories.DeletarTodosRegistros(Fcontexto.FRASE);

        return (byte)EnumUtils.StatusProc.Sucesso;
      }
      catch
      {
        return (byte)EnumUtils.StatusProc.ErroServidor;
      }
    }
  }
}
