using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using eassydental.Controllers;

namespace eassydental
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();

            // Configurando CORS para permitir todas as origens, métodos e cabeçalhos.
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            // ... outras configurações de serviços ...
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ... outras configurações ...

            // Habilitando a política CORS criada ("AllowAllOrigins")
            app.UseCors("AllowAllOrigins");

            // ... outras configurações ...
        }
    }
}
