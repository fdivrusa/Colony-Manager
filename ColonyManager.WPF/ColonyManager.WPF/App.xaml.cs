using ColonyManager.Core.ViewModels;
using ColonyManager.WPF.Views;
using System.Windows;

namespace ColonyManager.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeAutoMapper();
            base.OnStartup(e);

            var loginWindow = new LoginWindow();
            var loginVM = new LoginViewModel();
            loginVM.LoginCompleted += (sender, args) =>
            {
                MainWindow main = new MainWindow();

                loginWindow.Close();
                main.Show();
            };

            loginWindow.DataContext = loginVM;
            loginWindow.ShowDialog();

        }

        private void InitializeAutoMapper()
        {
            
        }
    }
}
