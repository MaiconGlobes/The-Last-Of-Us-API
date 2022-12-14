using API_REST_The_Last_Of_Us.Src;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Net;

namespace The_Last_Of_Us_API
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();

      services.AddControllersWithViews();

      services.AddSpaStaticFiles(configuration =>
      {
        configuration.RootPath = "wwwroot/build";
      });

      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

      services.AddMvc();

      services.AddSwaggerGen(options =>
      {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
          Title = "The Last Of Us - API",
          Version = "v1"
        });
        options.SchemaFilter<SwaggerExcludeFilter>();
      });

      services.AddSwaggerGenNewtonsoftSupport();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
      }

      app.UseSwagger();

      app.UseSwaggerUI(options =>
      {
        options.SwaggerEndpoint("../swagger/v1/swagger.json", "The Last Of Us API v1");
        options.DefaultModelsExpandDepth(-1);
        options.InjectStylesheet("/public/swagger-ui/custom.css");
      });

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseSpaStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        //endpoints.MapControllers();
        endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller}/{action=Index}/{id?}");
      });

      app.UseSpa(spa =>
      {
        spa.Options.SourcePath = "wwwroot";

        if (env.IsDevelopment())
        {
          spa.UseReactDevelopmentServer(npmScript: "start");
        }
      });

      app.Use(async (context, next) =>
      {
        var acceptHeader = context.Request.Headers["Accept"];
        var authorizationHeader = context.Request.Headers["Authorization"];

        if (!acceptHeader.ToString().Contains("application/json"))
        {
          context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
          return;
        }
        await next();
      });
    }
  }
}