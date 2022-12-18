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

    public IList<GrupoModel> PopularGrupo()
    {
      return new List<GrupoModel>
      {
        new GrupoModel
        {
          Id = 1,
          Titulo = "Independentes",
          Definicao = "São sobreviventes que lutam por sua própria sobrevivência e pelo bem-estar um do outro.",
        },
        new GrupoModel
        {
          Id = 2,
          Titulo = "Sentinéis",
          Definicao = "Um grupo de sobreviventes que tentam manter a ordem e a segurança em uma cidade chamada Jackson. Eles são liderados por Tommy e seguem regras rígidas para proteger sua comunidade.",
        },
        new GrupoModel
        {
          Id = 3,
          Titulo = "Conquistadores",
          Definicao = "Um grupo de sobreviventes que se estabeleceram em uma cidade chamada Salt Lake City e que controlam o comércio de recursos valiosos, como munição e medicamentos. Eles são liderados por David e usam a violência para manterem sua posição de poder.",
        },
        new GrupoModel
        {
          Id = 4,
          Titulo = "Fireflies",
          Definicao = "Um grupo de sobreviventes que se estabeleceram em uma cidade chamada Salt Lake City e que controlam o comércio de recursos valiosos, como munição e medicamentos. Eles são liderados por David e usam a violência para manterem sua posição de poder.",
        },
        new GrupoModel
        {
          Id = 5,
          Titulo = "Bandidos",
          Definicao = "Um grupo de sobreviventes que se aproveitam da situação pós-apocalíptica para cometer crimes e extorquir outros sobreviventes. Eles são liderados por Bill e são vistos como inimigos pelos outros grupos.",
        },
        new GrupoModel
        {
          Id = 6,
          Titulo = "Perseguidores ",
          Definicao = "Os Perseguidores são uma facção de sobreviventes hostis no jogo. Eles são um grupo de humanos que se adaptou ao mundo pós-apocalíptico criado pelo fungo Cordyceps e se dedicam a perseguir e capturar outros sobreviventes para aumentar seus próprios recursos e poder. Os Perseguidores são conhecidos por usar táticas agressivas e serem altamente treinados e equipados, o que os torna um grande perigo para os outros sobreviventes no jogo. Eles são um inimigo importante a ser enfrentado pelo protagonista, Joel, e sua companheira de viagem, Ellie, enquanto eles tentam sobreviver em um mundo perigoso e hostil.",
        },
        new GrupoModel
        {
          Id = 7,
          Titulo = "Runners",
          Definicao = "O fungo cordyceps é conhecido por infectar o cérebro de seus hospedeiros e alterar seu comportamento, deixando-os extremamente agressivos e incapazes de raciocinar de maneira lógica. Após ser mordido por um hospedeiro infectado ou ter inalado os esporos do fungo, os sintomas geralmente começam a aparecer em um período de um a dois dias. Os hospedeiros infectados que ainda estão no primeiro estágio da infecção são chamados de \"corredores\" devido ao seu hábito de perseguir animais ou pessoas saudáveis quando são detectados. Embora mantenham aparência humana, eles são considerados os inimigos mais fáceis de serem eliminados quando encontrados individualmente. No entanto, quando se juntam em grandes grupos, é melhor evitar o confronto e tentar fugir.",
        },
        new GrupoModel
        {
          Id = 8,
          Titulo = "Stalkers",
          Definicao = "Os Perseguidores são uma variante dos Infectados em The Last of Us. Eles atingem o segundo estágio de infecção após passar duas semanas como um Corredor, com o fungo no cérebro crescendo e danificando o córtex visual do hospedeiro. Os Perseguidores são conhecidos por serem mais silenciosos e por possuir um sentido auditivo aguçado. Eles costumam se reunir em grupos pequenos e se esconder em locais fechados e escuros, como antigos prédios ou túneis subterrâneos. Em The Last of Us: Parte II (2020), eles também podem se esconder atrás de paredes cobertas de fungos para atacar os jogadores de surpresa.",
        },
        new GrupoModel
        {
          Id = 9,
          Titulo = "Clickers",
          Definicao = "Os Estaladores são uma variante dos Infectados em The Last of Us. Eles são humanos que foram infectados pelo fungo Cordyceps e passaram um ano inteiro sem ser mortos por sobreviventes. Como resultado, eles atingem o terceiro estágio de infecção e se transformam em uma das criaturas mais temidas do jogo. Os Estaladores têm o crescimento fúngico enorme em seus rostos, o que os deixa completamente cegos. No entanto, eles desenvolveram uma forma primitiva de ecolocalização, emitindo sons de \"click\" que os ajudam a se orientar. Eles também são conhecidos por serem resistentes e agressivos, correndo diretamente para sua presa quando provocados. Apesar de serem vulneráveis ao fogo, os Estaladores podem ser atacados furtivamente com facas ou diretamente com algum tipo de bastão.",
        },
        new GrupoModel
        {
          Id = 10,
          Titulo = "Worms",
          Definicao = "Após um longo período de infecção pelo fungo cordyceps, os hospedeiros infectados atingem o estágio final da doença e se transformam em uma criatura conhecida como \"verme\". Neste estado, o fungo deforma o corpo do hospedeiro de maneira radical, cobrindo-o de grossas placas fúngicas que o tornam mais forte, resistente e difícil de ser eliminado. Além disso, os vermes também podem remover partes do fungo de seu próprio corpo e usá-las como bombas que liberam esporos. Na maioria dos jogos, essas criaturas só podem ser eliminadas com ataques de longa distância. É necessário enfraquecê-las com fogo intenso antes de usar o melhor de seu arsenal para acabar com elas.",
        },
        new GrupoModel
        {
          Id = 11,
          Titulo = "Trôpegos",
          Definicao = "Quando um hospedeiro infectado que está no processo de se transformar em um verme habita um ambiente muito úmido, o fungo passa por uma mutação e um aglomerado de esporos cresce na região da cabeça e dos ombros. Essas criaturas, conhecidas como \"trôpegos\", são menores e menos resistentes que os vermes, e não possuem bocas, o que as impede de morder. No entanto, ainda são extremamente perigosas, pois expelem esporos ácidos em suas vítimas. É importante manter distância desses infectados, pois ao serem eliminados, eles explodem e liberam ainda mais ácido. Essa variante de infectado foi introduzida somente em \"The Last of Us Parte II\", e é improvável que apareça na primeira temporada da adaptação para a HBO.",
        },
        new GrupoModel
        {
          Id = 12,
          Titulo = "Rei dos Ratos",
          Definicao = "Essa criatura nojenta e repulsiva é o resultado de alguns dos primeiros infectados terem sido mantidos em cativeiro em um hospital abandonado por 24 anos. O \"Rei dos Ratos\" (assim chamado em homenagem a um fenômeno raro no reino animal, onde um grupo de ratos foi encontrado com suas caudas interligadas e fundidas por cabelo e substâncias pegajosas) é uma mistura de todos os tipos de infectados existentes no universo de \"The Last of Us\", possuindo a velocidade de um perseguidor,  a ecolocalização de um estalador e a força de um verme. Como foi introduzido somente em \"The Last of Us Parte II\", é improvável que ele apareça na primeira temporada da nova série da HBO.",
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
          Nome =  "Ellie Leanne Joel (Ellie Williams)",
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
          Nome =  "Tess (Theresa Servopoulos)",
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
      };
    }
  }
}
