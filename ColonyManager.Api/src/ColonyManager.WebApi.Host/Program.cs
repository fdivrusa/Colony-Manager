using Microsoft.AspNetCore.Hosting;

namespace ColonyManager.WebApi.Host
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Serilog;
    using System;
    using System.IO;
    using System.Net;

    public class Program
    {
        protected Program()
        {

        }

        public static void Main(string[] args)
        {

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            try
            {
                Log.Information("Application Starting Up");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application failed to start correctly");
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
              Host.CreateDefaultBuilder(args)
                  .UseSerilog()
                  .ConfigureWebHostDefaults(webBuilder =>
                  {
                      webBuilder.UseKestrel()
                      .UseContentRoot(Directory.GetCurrentDirectory())
                      .UseUrls("https://*:49314", "http://*:49313")
                      .UseIISIntegration()
                      .UseStartup<Startup>();
                  });
    }
}
