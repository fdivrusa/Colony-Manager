using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace ColonyManager.WebApi.Host.Configurations
{
    public static class CorsConfiguration
    {
        public static IApplicationBuilder ConfigureCors(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            return app;
        }
    }
}
