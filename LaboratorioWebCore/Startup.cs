using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Repositories;
using LaboratorioWebCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LaboratorioWebCore
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var caminhoBanco = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory());
            var connectionString = string.Format(@"Server=(LocalDb)\MSSQLLocalDB; Initial Catalog = bd_laboratorio; Integrated Security = SSPI; AttachDBFilename = {0}\bd_laboratorio.mdf", caminhoBanco);

            services.AddDbContext<LaboratorioContexto>(options => options.UseSqlServer(connectionString));

            //REPOSITORY
            services.AddTransient<AgendamentoRepository>();
            services.AddTransient<AtendimentoRepository>();
            services.AddTransient<CidadeRepository>();
            services.AddTransient<ExameDaConsultaRepository>();
            services.AddTransient<ExameDoAtendimentoRepository>();
            services.AddTransient<ExameRepository>();
            services.AddTransient<PacienteRepository>();
            services.AddTransient<PlanoDeSaudeRepository>();

            //SERVICES
            services.AddTransient<AgendamentoService>();
            services.AddTransient<AtendimentoService>();
            services.AddTransient<CidadeService>();
            services.AddTransient<ExameDaConsultaService>();
            services.AddTransient<ExameDoAtendimentoService>();
            services.AddTransient<ExameService>();
            services.AddTransient<PacienteService, PacienteService>();
            services.AddTransient<PlanoDeSaudeService, PlanoDeSaudeService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
