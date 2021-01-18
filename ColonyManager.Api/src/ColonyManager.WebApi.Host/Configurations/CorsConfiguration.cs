using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
