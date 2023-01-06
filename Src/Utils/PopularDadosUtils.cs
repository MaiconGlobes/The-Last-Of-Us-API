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
    #region PopularSobre
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
    #endregion

    #region PopularLancamento
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
    #endregion

    #region PopularDesigner
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
    #endregion

    #region PopularPlataforma
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
    #endregion

    #region PopularEspecie
    public IList<EspecieModel> PopularEspecie()
    {
      return new List<EspecieModel>
      {
        new EspecieModel
        {
          Id = 1,
          Definicao = "Humano",
        },
        new EspecieModel
        {
          Id = 2,
          Definicao = "Infectado",
        },
      };
    }
    #endregion

    #region PopularGrupo
    public IList<GrupoModel> PopularGrupo()
    {
      return new List<GrupoModel>
      {
        new GrupoModel
        {
          Id = 1,
          Titulo = "Independentes",
          Definicao = "São sobreviventes que lutam por sua própria sobrevivência e pelo bem-estar um do outro.",
          Especie_id = 1,
        },
        new GrupoModel
        {
          Id = 2,
          Titulo = "Sentinéis",
          Definicao = "Um grupo de sobreviventes que tentam manter a ordem e a segurança em uma cidade chamada Jackson. Eles são liderados por Tommy e seguem regras rígidas para proteger sua comunidade.",
          Especie_id = 1,
        },
        new GrupoModel
        {
          Id = 3,
          Titulo = "Conquistadores",
          Definicao = "Um grupo de sobreviventes que se estabeleceram em uma cidade chamada Salt Lake City e que controlam o comércio de recursos valiosos, como munição e medicamentos. Eles são liderados por David e usam a violência para manterem sua posição de poder.",
          Especie_id = 1,
        },
        new GrupoModel
        {
          Id = 4,
          Titulo = "Fireflies",
          Definicao = "Um grupo de sobreviventes que se estabeleceram em uma cidade chamada Salt Lake City e que controlam o comércio de recursos valiosos, como munição e medicamentos. Eles são liderados por David e usam a violência para manterem sua posição de poder.",
          Especie_id = 1,
        },
        new GrupoModel
        {
          Id = 5,
          Titulo = "Bandidos",
          Definicao = "Um grupo de sobreviventes que se aproveitam da situação pós-apocalíptica para cometer crimes e extorquir outros sobreviventes. Eles são liderados por Bill e são vistos como inimigos pelos outros grupos.",
          Especie_id = 1,
        },
        new GrupoModel
        {
          Id = 6,
          Titulo = "Perseguidores ",
          Definicao = "Os Perseguidores são uma facção de sobreviventes hostis no jogo. Eles são um grupo de humanos que se adaptou ao mundo pós-apocalíptico criado pelo fungo Cordyceps e se dedicam a perseguir e capturar outros sobreviventes para aumentar seus próprios recursos e poder. Os Perseguidores são conhecidos por usar táticas agressivas e serem altamente treinados e equipados, o que os torna um grande perigo para os outros sobreviventes no jogo. Eles são um inimigo importante a ser enfrentado pelo protagonista, Joel, e sua companheira de viagem, Enquanto eles tentam sobreviver em um mundo perigoso e hostil.",
          Especie_id = 1,
        },
        new GrupoModel
        {
          Id = 7,
          Titulo = "Infectado Inicial",
          Definicao = "O primeiro estágio da infecção é conhecido como \"Infecção Inicial\", durante o qual o indivíduo ainda não apresenta sintomas evidentes da infecção, mas já está contaminado pelo fungo Ophiocordyceps unilateralis. O fungo se instala no sistema nervoso do hospedeiro e começa a controlar seus comportamentos.",
          Especie_id = 2,
        },
        new GrupoModel
        {
          Id = 8,
          Titulo = "Infectado Ativo",
          Definicao = "O primeiro estágio da infecção é conhecido como \"Infecção Inicial\", durante o qual o indivíduo ainda não apresenta sintomas evidentes da infecção, mas já está contaminado pelo fungo Ophiocordyceps unilateralis. O fungo se instala no sistema nervoso do hospedeiro e começa a controlar seus comportamentos.",
          Especie_id = 2,
        },
        new GrupoModel
        {
          Id = 9,
          Titulo = "Infectado Tardio",
          Definicao = "O primeiro estágio da infecção é conhecido como \"Infecção Inicial\", durante o qual o indivíduo ainda não apresenta sintomas evidentes da infecção, mas já está contaminado pelo fungo Ophiocordyceps unilateralis. O fungo se instala no sistema nervoso do hospedeiro e começa a controlar seus comportamentos.",
          Especie_id = 2,
        },
      };
    }
    #endregion

    #region PopularVersao
    public IList<VersaoModel> PopularVersao()
    {
      return new List<VersaoModel>
    {
      new VersaoModel
      {
        Id = 1,
        Descricao = "American Dreams",
      },
      new VersaoModel
      {
        Id = 2,
        Descricao = "Left Behind",
      },
      new VersaoModel
      {
        Id = 3,
        Descricao = "The Last of Us",
      },
    };
    }
    #endregion

    #region PopularPersonagem
    public IList<PersonagemModel> PopularPersonagem()
    {
      return new List<PersonagemModel>
    {
      new PersonagemModel
      {
        Id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
        Nome =  "Ellie Williams",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
        Nome =  "Joel Miller",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("bcd11b9e-12e3-454a-b584-a148b58f3427"),
        Nome =  "Sarah Miller",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("4039cf0a-ca49-4a9a-9e3e-31754d8cb104"),
        Nome =  "Tommy Miller",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
        Nome =  "Tess",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("3ef7803b-a61e-49f0-85ee-b19c2e2d4626"),
        Nome =  "Marlene",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("0ba0f1a3-5c6a-478e-971d-28495db5e386"),
        Nome =  "Bill",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("ba76f052-6607-4097-82c0-88e5a82b781d"),
        Nome =  "Henry",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("4697df37-694b-495e-a18d-8e5d1176e59d"),
        Nome =  "Sam",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("b471b4ad-59e7-4c54-b181-466cd09c708a"),
        Nome =  "David",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("3d55a8a1-cb03-4161-8e27-70c7ab090dda"),
        Nome =  "Abby",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("53b4e870-746f-4113-8e26-1358f3d2283d"),
        Nome =  "Dina",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("2a78e56b-4ce5-4f03-a796-60a2eb5198c3"),
        Nome =  "Jesse",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("99943e13-4b80-49d5-9056-43fd9c5035db"),
        Nome =  "Lev",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("8cf01e12-1938-4998-afb6-fe1ea2e17584"),
        Nome =  "Yara",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("5eeef74d-096c-4c97-97ef-bce95db779a2"),
        Nome =  "Manny",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("456bc8d7-9adb-412d-822b-9c355e72bc12"),
        Nome =  "Mel",
        Grupo_id = 1
      },
      new PersonagemModel
      {
        Id = new Guid("f3e22d07-e2aa-4fc7-9955-45cb879a48a5"),
        Nome =  "Jerry Anderson",
        Grupo_id = 1
      },

      new PersonagemModel
      {
        Id = new Guid("B5D918D8-6FBB-4D43-99E7-F5C3E8A3D3B3"),
        Nome =  "Runner",
        Grupo_id = 7
      },
      new PersonagemModel
      {
        Id = new Guid("3F2504E0-4F89-41D3-9A0C-0305E82C3301"),
        Nome =  "Stalker",
        Grupo_id = 8
      },
      new PersonagemModel
      {
        Id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
        Nome =  "Clicker",
        Grupo_id = 9
      },
      new PersonagemModel
      {
        Id = new Guid("5DF3D9EF-5A68-4A50-8020-A5D5CC5CA8A5"),
        Nome =  "Bloaters",
        Grupo_id = 9
      },
    };
    }
    #endregion

    #region PopularFrase
    public IList<FraseModel> PopularFrase()
    {
      return new List<FraseModel>
    {
      new FraseModel
      {
        Id = 1,
        Descricao = "Eu não sou mais uma criança. Eu posso lidar comigo mesmo. (Ellie, descrevendo suas próprias capacidades)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 2,
        Descricao = "Não tenho mais medo de morrer. Só tenho medo da dor. (Ellie, descrevendo seu medo da morte)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 3,
        Descricao = "Eu só quero ficar sozinha. (Expressando um desejo de solidão)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 4,
        Descricao = "Não é como se eu não estivesse acostumada com pessoas morrendo. É apenas, eu não esperava que fosse ele. (Ellie, descrevendo sua experiência com a perda)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 5,
        Descricao = "Eu não vou ser um fardo, eu prometo. Farei o que for preciso. (Expressando sua determinação em contribuir)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 6,
        Descricao = "Eu não vou te deixar. Eu não vou morrer. (Expressando sua lealdade a Joel)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 7,
        Descricao = "Eu não vou ser uma garotinha para sempre. Um dia, eu vou ser como você. Forte e corajoso. (Expressando sua ambição de ser como Joel)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 8,
        Descricao = "Não tenho medo de morrer. Eu só tenho medo de perder você. (Expressando seu medo de perder Joel)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 9,
        Descricao = "Eu odeio este lugar. Eu odeio o cheiro. Eu odeio o barulho. Eu odeio a maneira como se sente. (Ellie, descrevendo seus sentimentos negativos sobre a cidade)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 10,
        Descricao = "Estou com medo. (Expressando medo)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 11,
        Descricao = "Eu não posso simplesmente sentar aqui e não fazer nada. (Expressando seu desejo de agir)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 12,
        Descricao = "Eu não vou me esconder aqui para sempre. (Expressando seu desejo de deixar um lugar seguro)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 13,
        Descricao = "Eu não vou desistir. (Expressando determinação)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 14,
        Descricao = "Eu não quero mais estar aqui. (Expressando o desejo de sair)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 15,
        Descricao = "Eu não quero voltar para aquele lugar. (Ellie, descrevendo sua antipatia por um local específico)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 16,
        Descricao = "Eu não posso continuar correndo para sempre. (Expressando exaustão)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 17,
        Descricao = "Estou cansada de ficar com medo o tempo todo. (Expressando frustração com o constante sentimento de medo)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 18,
        Descricao = "Estou cansada de ficar sozinha. (Expressando um desejo de companheirismo)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 19,
        Descricao = "Eu não quero estar aqui quando isso acontecer. (Expressando o desejo de evitar um evento específico)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 20,
        Descricao = "Eu não quero voltar a essa vida. (Expressando uma antipatia por um estilo de vida específico)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 21,
        Descricao = "Eu não quero mais estar aqui. Quero ir para casa. (Expressando o desejo de voltar para casa)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 22,
        Descricao = "Estou cansado deste lugar. Quero ir a algum lugar novo. (Expressando um desejo de mudança)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 23,
        Descricao = "Estou cansado de sentir que tenho que ser forte o tempo todo. (Expressando o desejo de ser vulnerável)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 24,
        Descricao = "Estou cansado de fingir que está tudo bem. (Expressando o desejo de ser honesta sobre seus sentimentos)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 25,
        Descricao = "Eu não quero estar aqui quando está escuro. É muito assustador. (Expressando um medo do escuro)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 26,
        Descricao = "Estou cansado de fingir que não tenho medo. Tenho medo. (Expressando o desejo de admitir seu medo)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 27,
        Descricao = "Eu não quero mais estar aqui. Quero ir a algum lugar seguro. (Expressando um desejo de segurança)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 28,
        Descricao = "Estou cansado de fingir que não estou machucado. Estou magoado. (Expressando um desejo de admitir sua dor)",
        Personagem_id = new Guid("479f2095-5476-47c2-a3f4-87d14c6fe381"),
      },
      new FraseModel
      {
        Id = 29,
        Descricao = "Eu não vou te deixar. (Expressando seu compromisso e lealdade a Ellie)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 30,
        Descricao = "Estou aqui por você. (Expressando minha vontade de apoiar e ajudar Ellie de qualquer maneira que puder)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 31,
        Descricao = "Nós vamos passar por isso. (Expressando esperança e determinação para sobreviver em uma situação difícil)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 32,
        Descricao = "Farei o que for preciso. (Expressando a vontade de fazer sacrifícios para proteger Ellie e alcançar seus objetivos)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 33,
        Descricao = "Eu não vou te perder. (Expressando seu medo de perder Ellie e sua determinação em mantê-la segura)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 34,
        Descricao = "Eu vou protegê-lo. (Expressando seu desejo de manter Ellie segura e sua disposição de se colocar em perigo para fazê-lo)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 35,
        Descricao = "Estamos nisso juntos. (Expressando um senso de unidade e parceria com Ellie)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 36,
        Descricao = "Eu te amo. (Expressando meus profundos sentimentos de amor por Ellie)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 37,
        Descricao = "Eu não vou deixar nada acontecer com você. (Expressando minha determinação em manter Ellie a salvo de danos)",
        Personagem_id = new Guid("fc105ebc-0610-47af-8eea-fdde2db775b8"),
      },
      new FraseModel
      {
        Id = 38,
        Descricao = "Não vamos mais precisar de um lugar para esconder. (Tess fala isso para Joel quando eles estão se preparando para partir de uma cidade segura e seguir para o próximo destino.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 39,
        Descricao = "Eu estou cansada de ficar correndo, Joel. Estou cansada de fugir. (Tess fala isso enquanto eles estão sendo perseguidos por inimigos e tentando encontrar um lugar seguro.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 40,
        Descricao = "Não me faça fazer isso, Joel. Eu não posso fazer isso. (Tess fala isso quando ela é forçada a tomar uma decisão difícil que pode colocar sua vida em risco.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 41,
        Descricao = "Eu fiz uma promessa para nós dois. Eu vou mantê-la, independentemente do que aconteça. (Tess fala isso quando ela está determinada a cumprir sua promessa a Joel, mesmo que isso signifique enfrentar grandes desafios.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 42,
        Descricao = "Eu não posso fazer isso sozinha. Eu preciso de você aqui comigo. (Tess fala isso quando ela se sente sozinha e precisa de apoio de Joel.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 43,
        Descricao = "Não importa o que aconteça, eu sempre vou estar aqui do seu lado. (Tess fala isso para Joel quando ela quer deixar claro que ela sempre estará lá para ele.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 44,
        Descricao = "Eu confio em você, Joel. Eu sempre confiei. (Tess fala isso quando ela quer deixar claro que confia em Joel e que sempre confiou nele.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 45,
        Descricao = "Eu não posso perder você, Joel. Você é tudo o que eu tenho. (Tess fala isso quando ela tem medo de perder Joel e sabe que ele é a única pessoa que lhe resta.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 46,
        Descricao = "Eu só quero que você saiba que eu te amo, Joel. Eu sempre te amei. (Tess fala isso quando ela quer deixar claro que ama Joel e sempre o amou.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      },
      new FraseModel
      {
        Id = 47,
        Descricao = "Eu vou fazer o que for preciso para garantir a segurança de nós dois, Joel. Eu te prometo isso. (Tess fala isso quando ela está disposta a tomar qualquer medida necessária para garantir a segurança de ambos.)",
        Personagem_id = new Guid("3ce1f89c-06b2-441c-86a8-d437c4680569"),
      }
    };
    }
    #endregion
  }
}
