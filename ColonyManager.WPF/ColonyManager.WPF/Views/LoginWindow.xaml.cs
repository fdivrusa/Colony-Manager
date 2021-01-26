using ColonyManager.Core.ViewModels;
using ColonyManager.Global;
using System.Configuration;
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
        public LoginWindow()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitConfiguration();
        }

        private void InitConfiguration()
        {
            StringBuilder errorMessage = new StringBuilder();
            LocalSettings.ColonyManagerApiUrl = ConfigurationManager.AppSettings["ColonyManagerApiUrl"];

            if (string.IsNullOrEmpty(LocalSettings.ColonyManagerApiUrl))
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
