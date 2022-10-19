using API_REST_The_Last_Of_Us.Src.Services;
using Microsoft.OpenApi.Models;
   using Swashbuckle.AspNetCore.SwaggerGen;

   namespace API_REST_The_Last_Of_Us.Src
   {
      public class SwaggerExcludeFilter : ISchemaFilter
      {
         public Contexto Fcontexto { get; set; }
         public void Apply(OpenApiSchema schema, SchemaFilterContext context)
         {
            var excludeProperties = new[] { "lazyLoader" };

            foreach (var prop in excludeProperties)
               if (schema.Properties != null)
                  if (schema.Properties.ContainsKey(prop))
                     schema.Properties.Remove(prop);
         }
      }
   }
