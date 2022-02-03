using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Portfolio.Repositories;
using Portfolio.Repositories.Context;
using Portfolio.Repositories.Contracts;
using Portfolio.Services;
using Portfolio.Services.Contracts;

namespace PortfolioApi
{
    public class Startup
    {
        private static string Host = "ec2-54-157-160-218.compute-1.amazonaws.com";
        private static string User = "ytkwxpjhxnywzk";
        private static string DBname = "df6jam2m670q6b";
        private static string Password = "3036552fcdba8230bb103b933a485af37cf817438b15b08a796862f452d72f39";
        private static string Port = "5432";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connString =
                string.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSL Mode=Require;Trust Server Certificate=true",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);
            services.AddDbContext<DataContext>(opt => opt.UseNpgsql(connString));
            services.AddControllers()
                    .AddNewtonsoftJson(
                        x => x.SerializerSettings.ReferenceLoopHandling =
                            Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    );
            services.AddScoped<IDeveloperService, DeveloperService>();
            services.AddScoped<IDeveloperRepository, DeveloperRepository>();
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Portfolio.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Portfolio.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(cors => cors.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
