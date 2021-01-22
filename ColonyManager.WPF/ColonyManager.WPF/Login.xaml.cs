using ColonyManager.Core;
using System.Configuration;
using System.Text;
using System.Windows;

namespace ColonyManager.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
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
                MessageBox.Show($"{errorMessage} \n Please contact your administrator", "Configuration error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
