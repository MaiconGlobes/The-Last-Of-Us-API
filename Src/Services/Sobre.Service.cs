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
                var ListaDados = FSobreRepositories.BuscarTodosRegistros();

                return ((byte)EnumUtils.StatusProc.Sucesso, ResponseUtils.Instancia().RetornoOk(ListaDados));
            }
            catch
            {
                return ((byte)EnumUtils.StatusProc.ErroServidor, null);
            }
        }
    }
}
