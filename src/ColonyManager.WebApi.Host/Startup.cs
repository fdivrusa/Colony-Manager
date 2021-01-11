using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ColonyManager.WebApi.Host.Configurations;
using ColonyManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ColonyManager.Application;

namespace ColonyManager.WebApi.Host
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
            services.ConfigureColonyManagerDbContext(Configuration.GetConnectionString("DefaultConnection"));
            services.AddSwagger();
            services.AddRegisteredServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureSwagger(env);

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
