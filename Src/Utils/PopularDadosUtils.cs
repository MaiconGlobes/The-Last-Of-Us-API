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
         if (FInstancia == null)
         {
               FInstancia = new PopularDadosUtils();
         }
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
            Id = new Guid("5C354946-207C-44B6-A434-7556002EC55F"),
            Versao =  "The last Of Us",
            Data = new DateTime(2013, 6, 14, 0, 0, 0, DateTimeKind.Unspecified),
            Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
         },
         new LancamentoModel
         {
            Id = new Guid("BE16A989-4CD9-4779-9362-3D2334486E0C"),
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
               Id = new Guid("5C354946-207C-44B6-A434-7556002EC55F"),
               Nome = "Bruce Straley",
               Perfil = "https://pt.wikipedia.org/wiki/Bruce_Straley",
               Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
            },
            new DesignerModel
            {
               Id = new Guid("BE16A989-4CD9-4779-9362-3D2334486E0C"),
               Nome = "Neil Druckmann",
               Perfil = "https://pt.wikipedia.org/wiki/Neil_Druckmann",
               Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
            },
            new DesignerModel
            {
               Id = new Guid("7986FF87-9714-4D0E-A96A-5D0BA2590595"),
               Nome = "Ricky Cambier",
               Perfil = "",
               Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
            },
            new DesignerModel
            {
               Id = new Guid("6EF949C6-D579-4F75-B77F-690153580B5A"),
               Nome = "Jacob Minkoff",
               Perfil = "https://callofduty.fandom.com/wiki/Jacob_Minkoff",
               Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
            },
            new DesignerModel
            {
               Id = new Guid("DC7F1A1B-7E0F-48FA-9236-E24FD7F30E9E"),
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
               Id = new Guid("5C354946-207C-44B6-A434-7556002EC55F"),
               Versao = "The Last of us",
               Console = "Play Station III",
               Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
            },
            new PlataformaModel
            {
               Id = new Guid("BE16A989-4CD9-4779-9362-3D2334486E0C"),
               Versao = "The Last of us",
               Console = "Play Station IV",
               Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
            },
            new PlataformaModel
            {
               Id = new Guid("7986FF87-9714-4D0E-A96A-5D0BA2590595"),
               Versao = "The Last of us II",
               Console = "Play Station V",
               Sobre_id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
            },
         };
      }

      public IList<FraseModel> PopularFrase()
      {
         return new List<FraseModel>
         {
            new FraseModel
            {
               Id = new Guid("5C354946-207C-44B6-A434-7556002EC55F"),
               Descricao = "Há um milhão de maneiras que poderiam nos ter feito morrer antes de hoje. E um milhão de maneiras que poderiam nos fazer morrer antes de amanhã. Mas nós lutamos, por cada segundo que passamos juntas. Quer sejam dois minutos, quer sejam dois dias, não desistimos disso. Eu não quero desistir disso.",
               Personagem = "Riley",
            },
            new FraseModel
            {
               Id = new Guid("BE16A989-4CD9-4779-9362-3D2334486E0C"),
               Descricao = "Depois de tudo o que passamos juntos. De tudo o que eu fiz. Não pode ser em vão.",
               Personagem = "Ellie",
            },
            new FraseModel
            {
               Id = new Guid("7986FF87-9714-4D0E-A96A-5D0BA2590595"),
               Descricao = "Sabe, por pior que aquelas coisas sejam, pelo menos são previsíveis. São as pessoas normais que me assustam.",
               Personagem = "Bill",
            },
            new FraseModel
            {
               Id = new Guid("F744346E-CC98-41C7-B189-E27B603F1A2C"),
               Descricao = "Todos que eu amava me deixaram ou morreram, todos... exceto você. Então não diga que eu estaria mais segura com outra pessoa porque a verdade é que eu só estaria mais assustada.",
               Personagem = "Ellie",
            },
            new FraseModel
            {
               Id = new Guid("91248B35-2785-4BF2-AB7A-E51808686A49"),
               Descricao = "Por muito tempo, tenho lutado para sobreviver. E você... Seja o que for, você sempre encontra um motivo para viver.",
               Personagem = "Joel",
            },
            new FraseModel
            {
               Id = new Guid("DD9A5AAB-4204-4500-9E74-E40F7D040485"),
               Descricao = "Vamos apenas esperar. Você sabe que nós podemos... ser poéticas e simplesmente perder a cabeça juntas.",
               Personagem = "Riley",
            },
            new FraseModel
            {
               Id = new Guid("CCBDD8A3-4CA3-4126-8CE9-3FF2209BE078"),
               Descricao = "Quem precisa não escolhe.",
               Personagem = "Tess",
            },
            new FraseModel
            {
               Id = new Guid("1DC8AC8E-C12E-4620-A29D-011AE39EF4D7"),
               Descricao = "Todos que eu amava me deixaram ou morreram, todos… exceto você. Então não diga que eu estaria seguro com o outro porque eu ficaria com mais medo.",
               Personagem = "Ellie",
            },
           new FraseModel
            {
               Id = new Guid("8A690575-232C-4A33-B4C9-F6390D4FDDF2"),
               Descricao = "Depois de tudo o que vivemos, o que fizemos, não pode ser por nada.",
               Personagem = "Ellie",
            },
            new FraseModel
            {
               Id = new Guid("59F6B265-F2B8-4B81-AEC1-3735F5372959"),
               Descricao = "Quando você estiver perdido na escuridão, procure a luz, acredite nos vaga-lumes.",
               Personagem = "Joel ",
            },
            new FraseModel
            {
               Id = new Guid("D6EB8320-C687-4963-A765-B405996D9250"),
               Descricao = "Não importa o quanto você tente, você não pode escapar do seu passado.",
               Personagem = "Joel",
            },
         };
      }
   }
}
