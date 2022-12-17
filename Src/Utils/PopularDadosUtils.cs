using API_REST_The_Last_Of_Us.Src.Models.Entity;
using System;
using System.Collections.Generic;

namespace API_REST_The_Last_Of_Us.Src.Utils
{
  public class PopularDadosUtils
  {
    private static PopularDadosUtils FInstancia { get; set; }

    public static PopularDadosUtils Instancia()
    {
      FInstancia ??= new PopularDadosUtils();
      return FInstancia;
    }

    public IList<SobreModel> PopularSobre()
    {
      return new List<SobreModel>
      {
        new SobreModel {
          Id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
          Titulo =  "The Last of us",
          Sinopse = "The Last of Us é um jogo eletrônico pós-apocalíptico de ação-aventura e sobrevivência apresentado a partir de uma perspectiva em terceira pessoa. O jogador atravessa uma série de ambientes arruinados, passando por locais variados como cidades, florestas, edifícios e esgotos a fim de avançar pela história e concluir a missão.",
          Missao = "Escoltar uma jovem sobrevivente até um grupo de resistentes amigáveis denominados Fireflies (vagalumes).",
          Desenvolvedor = "Naughty Dog",
          Escritor = "Neil Druckmann",
          Compositor = "Gustavo Santaolalla",
          Direito_Autoral = "Sony Computer Entertainment",
          Genero = "Ação/Aventura, Terror/Sobrevivência",
          Perpectiva = "3ª Pessoa",
          Classificacao = "ESRB: M, PEGI: 18, ACB: R18+, CERO: Z",
          Engine = "Havok",
        }
      };
    }

    public IList<LancamentoModel> PopularLancamento()
    {
      return new List<LancamentoModel>
      {
        new LancamentoModel
        {
          Id = 1,
          Versao =  "The last Of Us",
          Data = new DateTime(2013, 6, 14, 0, 0, 0, DateTimeKind.Unspecified),
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new LancamentoModel
        {
          Id = 2,
          Versao =  "The last Of Us II",
          Data = new DateTime(2020, 6, 19, 0, 0, 0, DateTimeKind.Unspecified),
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        }
      };
    }

    public IList<DesignerModel> PopularDesigner()
    {
      return new List<DesignerModel>
      {
        new DesignerModel
        {
          Id = 1,
          Nome = "Bruce Straley",
          Perfil = "https://pt.wikipedia.org/wiki/Bruce_Straley",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new DesignerModel
        {
          Id = 2,
          Nome = "Neil Druckmann",
          Perfil = "https://pt.wikipedia.org/wiki/Neil_Druckmann",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new DesignerModel
        {
          Id = 3,
          Nome = "Ricky Cambier",
          Perfil = "",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new DesignerModel
        {
          Id = 4,
          Nome = "Jacob Minkoff",
          Perfil = "https://callofduty.fandom.com/wiki/Jacob_Minkoff",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new DesignerModel
        {
          Id = 5,
          Nome = "Benson Russell",
          Perfil = "",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        }
      };
    }

    public IList<PlataformaModel> PopularPlataforma()
    {
      return new List<PlataformaModel>
      {
        new PlataformaModel
        {
          Id = 1,
          Versao = "The Last of us",
          Console = "Play Station III",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new PlataformaModel
        {
          Id = 2,
          Versao = "The Last of us",
          Console = "Play Station IV",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new PlataformaModel
        {
          Id = 3,
          Versao = "The Last of us II",
          Console = "Play Station V",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
      };
    }

    public IList<VersaoModel> PopularVersao()
    {
      return new List<VersaoModel>
      {
        new VersaoModel
        {
          Id = 1,
          Descricao = "American Dreams",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new VersaoModel
        {
          Id = 2,
          Descricao = "Left Behind",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
        new VersaoModel
        {
          Id = 3,
          Descricao = "The Last of Us",
          Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        },
      };
    }

    public IList<PersonagemModel> PopularPersonagem()
    {
      return new List<PersonagemModel>
      {
        new PersonagemModel
        {
          Id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
          Nome =  "Ellie Williams",
        },
        new PersonagemModel
        {
          Id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
          Nome =  "Joel Miller",
        },
        new PersonagemModel
        {
          Id = new Guid("bcd11b9e-12e3-454a-b584-a148b58f3427"),
          Nome =  "Sarah Miller",
        },
        new PersonagemModel
        {
          Id = new Guid("4039cf0a-ca49-4a9a-9e3e-31754d8cb104"),
          Nome =  "Tommy Miller",
        },
        new PersonagemModel
        {
          Id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
          Nome =  "Tess (Theresa Servopoulos)",
        },
        new PersonagemModel
        {
          Id = new Guid("3ef7803b-a61e-49f0-85ee-b19c2e2d4626"),
          Nome =  "Marlene",
        },
        new PersonagemModel
        {
          Id = new Guid("0ba0f1a3-5c6a-478e-971d-28495db5e386"),
          Nome =  "Bill",
        },
        new PersonagemModel
        {
          Id = new Guid("ba76f052-6607-4097-82c0-88e5a82b781d"),
          Nome =  "Henry",
        },
        new PersonagemModel
        {
          Id = new Guid("4697df37-694b-495e-a18d-8e5d1176e59d"),
          Nome =  "Sam",
        },
        new PersonagemModel
        {
          Id = new Guid("b471b4ad-59e7-4c54-b181-466cd09c708a"),
          Nome =  "David",
        },
        new PersonagemModel
        {
          Id = new Guid("3d55a8a1-cb03-4161-8e27-70c7ab090dda"),
          Nome =  "Abby",
        },
        new PersonagemModel
        {
          Id = new Guid("53b4e870-746f-4113-8e26-1358f3d2283d"),
          Nome =  "Dina",
        },
        new PersonagemModel
        {
          Id = new Guid("2a78e56b-4ce5-4f03-a796-60a2eb5198c3"),
          Nome =  "Jesse",
        },
        new PersonagemModel
        {
          Id = new Guid("99943e13-4b80-49d5-9056-43fd9c5035db"),
          Nome =  "Lev",
        },
        new PersonagemModel
        {
          Id = new Guid("8cf01e12-1938-4998-afb6-fe1ea2e17584"),
          Nome =  "Yara",
        },
        new PersonagemModel
        {
          Id = new Guid("5eeef74d-096c-4c97-97ef-bce95db779a2"),
          Nome =  "Manny",
        },
        new PersonagemModel
        {
          Id = new Guid("456bc8d7-9adb-412d-822b-9c355e72bc12"),
          Nome =  "Mel",
        },
        new PersonagemModel
        {
          Id = new Guid("f3e22d07-e2aa-4fc7-9955-45cb879a48a5"),
          Nome =  "Jerry Anderson",
        },
      };
    }

    public IList<FraseModel> PopularFrase()
    {
      return new List<FraseModel>
      {
        new FraseModel
        {
          Id = 1,
          Descricao = "Depois de tudo o que passamos juntos. De tudo o que eu fiz. Não pode ser em vão.",
          Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
        },
        new FraseModel
        {
          Id = 2,
          Descricao = "Todos que eu amava me deixaram ou morreram, todos... exceto você. Então não diga que eu estaria mais segura com outra pessoa porque a verdade é que eu só estaria mais assustada.",
          Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
        },
        new FraseModel
        {
          Id = 3,
          Descricao = "Há um milhão de maneiras pelas quais deveríamos ter morrido antes de hoje, e um milhão de maneiras pelas quais podemos morrer amanhã.",
          Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
        },
        new FraseModel
        {
          Id = 4,
          Descricao = "Isso se chama sorte, e vai acabar.",
          Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
        },
        new FraseModel
        {
          Id = 5,
          Descricao = "Se Deus me desse uma segunda chance, eu faria tudo igual",
          Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
        },
/*        new FraseModel
        {
          Id = 1,
          Descricao = "aaaaa",
          Personagem_id = new Guid(""),
        },*/
       
      };
    }
  }
}
