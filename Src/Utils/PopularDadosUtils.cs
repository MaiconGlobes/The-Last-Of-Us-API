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
               Descricao = @"The Last of Us é um jogo eletrônico pós-apocalíptico de ação-aventura e sobrevivência apresentado a partir de uma perspectiva em terceira pessoa. O jogador atravessa uma série de ambientes arruinados, passando por locais variados como cidades, florestas, edifícios e esgotos a fim de avançar pela história e concluir a missão.",
               Missao = @"Escoltar uma jovem sobrevivente até um grupo de resistentes amigáveis denominados Fireflies (vagalumes).",
               Desenvolvedor = "Naughty Dog",
               Direito_Autoral = "Sony Computer Entertainment",
               Genero = "Ação/Aventura, Terror/Sobrevivência",
               Perpectiva = "3ª Pessoa",
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
   }
}
