using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ColonyManager.WebApi.Host.Configurations;
using ColonyManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ColonyManager.Application;
using ColonyManager.Core;
using ColonyManager.Utility.Middlewares;
using Serilog;

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
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);
            services.AddCors();
            services.ConfigureColonyManagerDbContext(Configuration.GetConnectionString("DefaultConnection"));
            services.AddSwagger();
            services.AddRegisteredServices();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureCors(env);
            app.ConfigureSwagger(env);
            app.UseHttpsRedirection();

            app.UseSerilogRequestLogging();

            app.UseRouting();

            // global error handler
            app.UseMiddleware<ErrorHandlerMiddleware>();

            // custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
