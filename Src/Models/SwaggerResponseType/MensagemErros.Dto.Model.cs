using API_REST_The_Last_Of_Us.Src.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_REST_The_Last_Of_Us.Src.Models.SwaggerResponseType
{
   public class MensagemErros
   {
      public byte Codigo { get; set; }

      public string Descricao { get; set; }
   }
}
