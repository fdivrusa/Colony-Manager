using Microsoft.AspNetCore.Hosting;

namespace ColonyManager.WebApi.Host
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Serilog;
    using System;
    using System.IO;

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
                      webBuilder.UseStartup<Startup>()
                      .UseKestrel()
                      .UseContentRoot(Directory.GetCurrentDirectory())
                      .UseUrls("https://*:5001", "http://*:5000")
                      .UseIISIntegration();
                  });
    }
}
