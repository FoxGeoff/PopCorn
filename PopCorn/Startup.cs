using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Popcorn.Data;
using Microsoft.EntityFrameworkCore;
using PopCorn.Services;
using PopCorn.Data;
using Swashbuckle.AspNetCore.Swagger;

namespace PopCorn
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
            services.AddDbContext<MaterialsContext>(cfg => cfg.UseSqlServer(Configuration.GetConnectionString("MaterialDataConnection")));

            services.AddTransient<IMailService, NullMailService>();
            //TODO: Support for real mail service

            //-- services.AddTransient<MaterialDataSeeder>();

            services.AddScoped<IMaterialsRepository, MaterialsRepository>();

            //https://github.com/domaindrivendev/Swashbuckle.AspNetCore
            //https://localhost:63287/swagger/ui/index.html
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Material Data API",
                    Description = "ASP.NET Core2.x /Angular4.x Material Data API Swagger Documentation",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Geoff Fox", Url = "https://fox-graphics.com" },
                    License = new License { Name = "MIT", Url = "https://en.wikipedia.org/wiki/MIT_License" }
                });

                //Add XML comment document by uncommenting the following
                // var filePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "MyApi.xml");
                // options.IncludeXmlComments(filePath);

            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            //***************************************************************************
            //This would need to be locked down as needed (very open right now)
            app.UseCors((corsPolicyBuilder) =>
            {
                corsPolicyBuilder.AllowAnyOrigin();
                corsPolicyBuilder.AllowAnyMethod();
                corsPolicyBuilder.AllowAnyHeader();
                corsPolicyBuilder.WithExposedHeaders("X-InlineCount");
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();

            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            // Visit http://localhost:5000/swagger
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            //***************************************************************************


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });

            
        }
    }
}
