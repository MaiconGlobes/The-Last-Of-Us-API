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
			   Sinopse = @"The Last of Us é um jogo eletrônico pós-apocalíptico de ação-aventura e sobrevivência apresentado a partir de uma perspectiva em terceira pessoa. O jogador atravessa uma série de ambientes arruinados, passando por locais variados como cidades, florestas, edifícios e esgotos a fim de avançar pela história e concluir a missão.",
			   Missao = @"Escoltar uma jovem sobrevivente até um grupo de resistentes amigáveis denominados Fireflies (vagalumes).",
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
	}
}
