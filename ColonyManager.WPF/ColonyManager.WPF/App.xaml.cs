using ColonyManager.Core.Services;
using ColonyManager.Core.Services.Interfaces;
using ColonyManager.Core.ViewModels;
using ColonyManager.Global;
using ColonyManager.WPF.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;
using System.Windows;

namespace ColonyManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public IServiceProvider _serviceProvider { get; private set; }
        public IConfiguration _configuration { get; private set; }
        private readonly IHost _host;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            ConfigureLogger(_configuration);
            
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            serviceCollection.Configure<AppSettings>(_configuration.GetSection("AppSettings"));
            _serviceProvider = serviceCollection.BuildServiceProvider();

            try
            {
                Log.Information("WPF application starting up");

                var loginWindow = _serviceProvider.GetRequiredService<LoginWindow>();
                var loginVM = _serviceProvider.GetRequiredService<LoginViewModel>();

                loginVM.LoginCompleted += (sender, args) =>
                {
                    MainWindow mainWindow = new MainWindow();
                    loginWindow.Close();
                    mainWindow.Show();
                };

                loginWindow.DataContext = loginVM;
                loginWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "WPF application failed to start correctly");
                throw;
            }
            finally
            {
                Log.Information("Closing and flushing logger");
                Log.CloseAndFlush();
            }
        }

        private void ConfigureLogger(IConfiguration _configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(_configuration)
                .CreateLogger();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            //Services
            services.AddScoped<IAccountService, AccountService>();

            //VIewModel
            services.AddTransient(typeof(LoginViewModel));

            //View
            services.AddTransient(typeof(LoginWindow));

            //Others
            services.AddLogging(x =>
            {
                x.AddSerilog(dispose: true);
            });
        }
    }
}
