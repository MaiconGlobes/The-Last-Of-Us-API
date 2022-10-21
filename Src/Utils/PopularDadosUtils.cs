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

      public IList<Sobre> PopularSobre()
      {
         return new List<Sobre>
         {
            new Sobre {
               Id = new Guid("606ED30A-2F16-47FF-8812-D22B4B169C58"),
               Titulo =  "The Last of us",
               Descricao = @"The Last of Us é um jogo eletrônico pós-apocalíptico de ação-aventura e sobrevivência apresentado a partir de uma perspectiva em terceira pessoa. 
                             O jogador atravessa uma série de ambientes arruinados, passando por locais variados como cidades, florestas, edifícios e esgotos a fim de avançar pela história e concluir a missão."
            }
         };
      }
   }
}
