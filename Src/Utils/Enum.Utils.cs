namespace API_REST_The_Last_Of_Us.Src.Utils
{
   public class EnumUtils
   {
      private static EnumUtils FInstancia { get; set; }

      public static EnumUtils Instancia()
      {
         FInstancia ??= new EnumUtils();
         return FInstancia;
      }

      public enum StatusProc : byte
      {
         Sucesso = 3,
         NaoLocalizado = 20,
         ErroServidor = 99
      }
   }
}
