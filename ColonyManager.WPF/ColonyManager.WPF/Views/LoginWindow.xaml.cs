using ColonyManager.Core.Services.Interfaces;
using ColonyManager.Core.ViewModels;
using ColonyManager.Global;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ColonyManager.WPF.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IAccountService _accoutnService;
        private readonly AppSettings _appSettings;
        private readonly ILogger<LoginViewModel> _logger;

        public LoginWindow(IAccountService accountService, IOptions<AppSettings> appSettings, ILogger<LoginViewModel> logger) 
        {
            _appSettings = appSettings.Value;
            _accoutnService = accountService;
            _logger = logger;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitConfiguration();
        }

        private void InitConfiguration()
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrEmpty(_appSettings.ColonyManagerApiUrl))
            {
                errorMessage.AppendLine("Cannot load ColonyManagerApiUrl value from configuration");
            }

            if (!string.IsNullOrEmpty(errorMessage.ToString()))
            {
                MessageBox.Show($"{errorMessage} \n Please contact the helpdesk", "Configuration error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                ((dynamic)this.DataContext).Password = ((PasswordBox)sender).SecurePassword;
            }
        }
    }
}
