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
		  Id = Guid.NewGuid(),
		  Nome =  "Ellie",
		},
		new PersonagemModel
		{
		  Id = Guid.NewGuid(),
		  Nome =  "Joel",
		},
		new PersonagemModel
		{
		  Id = Guid.NewGuid(),
		  Nome =  "Sarah",
		},
		new PersonagemModel
		{
		  Id = Guid.NewGuid(),
		  Nome =  "Tommy",
		},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Tess",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Marlene",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Bill",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Henry",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Sam",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "David",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Abby",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Dina",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Jesse",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Lev",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Yara",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Manny",
			},
			new PersonagemModel
			{
			   Id = Guid.NewGuid(),
			   Nome =  "Mel",
			},
		 };
		}
	}
}
