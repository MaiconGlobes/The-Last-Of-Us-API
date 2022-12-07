using API_REST_The_Last_Of_Us.Src.Utils;

namespace API_REST_The_Last_Of_Us.Src.Services
{
	public class SobreService
	{
		public Contexto Fcontexto { get; set; }
		private SobreRepositories FSobreRepositories { get; set; }

		public SobreService()
		{
			Fcontexto = new Contexto();
			FSobreRepositories = new SobreRepositories();
		}

		public (byte Status, object Json) BuscarTodosRegistros()
		{
			try
			{
				var listaDados = FSobreRepositories.BuscarTodosRegistros();

				return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(listaDados));
			}
			catch
			{
				return ((byte)EnumUtils.StatusProc.ErroServidor, null);
			}
		}
	}
}
