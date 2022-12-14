using System;
using System.Collections.Generic;

/*
"Não importa o que aconteça, você continua encontrando algo pelo qual lutar. Ellie",
"Eu sou apenas uma garota, não uma ameaça. Ellie",
"Essa é a nossa rotina. Dia e noite, tudo o que fazemos é sobreviver. Isso nunca para. Ele me contou como essas ruas estavam lotadas de pessoas apenas vivendo suas vidas. Deve ter sido bom. Joel",
"Eu acho que não importa o quanto você tente, você não pode escapar do seu passado. Joel",
"Eu acho que não importa o quanto você tente, você não pode escapar do seu passado. Joel",
"Eu não posso deixar você. Joel",
"Eu praticamente perdi tudo. E então você aparece e de alguma forma nós a encontramos bem a tempo de salvá-la. Talvez fosse para ser. Joel",
*/

namespace API_REST_The_Last_Of_Us.Src.Utils
{
  public class ResponseUtils
  {
    private static ResponseUtils FInstancia { get; set; }
    private object FObjJSON { get; set; }

    public static ResponseUtils Instancia()
    {
      FInstancia ??= new ResponseUtils();
      return FInstancia;
    }

    internal virtual Object RetornoOk(Object ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Sucesso",
          codigo_status = EnumUtils.StatusProc.Sucesso,
          dados = ADados
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoOk<T>(List<T> ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Sucesso",
          codigo_status = EnumUtils.StatusProc.Sucesso,
          dados = ADados
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoCreated<T>(List<T> ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Sucesso",
          codigo_status = EnumUtils.StatusProc.Sucesso,
          dados = ADados
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoCreated(Object ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Sucesso",
          codigo_status = EnumUtils.StatusProc.Sucesso,
          dados = ADados
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoNotAcceptable<T>(List<T> ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Registro não localizado",
          codigo_status = EnumUtils.StatusProc.NaoLocalizado,
          mensagem = new
          {
            descricao = "O registro que está tentando realizar a operação não se encontra no banco de dados."
          }
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoNotAcceptable(Object ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Registro não localizado",
          codigo_status = EnumUtils.StatusProc.SemRegistros,
          mensagem = new
          {
            descricao = "O registro que está tentando realizar a operação não se encontra no banco de dados."
          }
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoNotFound<T>(List<T> ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "A Consulta não retornou registros",
          codigo_status = EnumUtils.StatusProc.SemRegistros,
          dados = ADados
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoNotFound(Object ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "A Consulta não retornou registros",
          codigo_status = EnumUtils.StatusProc.SemRegistros,
          dados = ADados
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoDuplicated<T>(List<T> ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Duplicidade de registro",
          codigo_status = EnumUtils.StatusProc.RegistroDuplicado,
          mensagem = new
          {
            descricao = "O registro que está tentando inserir já se encontra no banco de dados."
          }
        }
      };

      return FObjJSON;
    }

    internal virtual object RetornoDuplicated(Object ADados)
    {
      FObjJSON = new
      {
        retorno = new
        {
          status = "Duplicidade de registro",
          codigo_status = EnumUtils.StatusProc.RegistroDuplicado,
          mensagem = new
          {
            descricao = "Erro de duplicidade de registro."
          }
        }
      };

      return FObjJSON;
    }
  }
}
