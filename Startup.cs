using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Telefin.Models;

namespace Telefin
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
        Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
            Configuration["Data:3dProdLocation:ConnectionString"]));
            services.AddTransient<IPrintRepository, EFPrintRepository>();
            services.AddMvc();
        }
            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app)
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseStaticFiles();
                app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Print}/{action=Index}");
                });
                SeedData.EnsurePopulated(app);
            }
        }
    }