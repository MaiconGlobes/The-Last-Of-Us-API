using API_REST_The_Last_Of_Us.Src;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace API_REST_The_Last_Of_Us
{
   public class Startup
   {
      public Startup(IConfiguration configuration)
      {
         Configuration = configuration;
      }

      public IConfiguration Configuration { get; }

      public void ConfigureServices(IServiceCollection services)
      {
         services.AddControllers();

         /*services.AddControllersWithViews().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
         ); 
*/
         services.AddSwaggerGenNewtonsoftSupport();

         services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

         services.AddMvc().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

         services.AddSwaggerGen(options =>
         {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "The Last Of Us - API", Version = "v1" });
            options.SchemaFilter<SwaggerExcludeFilter>();
         });
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }

         app.UseSwagger();

         app.UseSwaggerUI(options =>
         {
            options.SwaggerEndpoint("../swagger/v1/swagger.json", "The Last Of Us API v1");
            options.DefaultModelsExpandDepth(-1);
         });

         app.UseRouting();

         app.UseAuthorization();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapControllers();
         });
      }
   }
}
