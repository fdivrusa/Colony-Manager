using ColonyManager.Core.ViewModels;
using ColonyManager.WPF.Pages;
using System.Windows;
using System.Windows.Controls;

namespace ColonyManager.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PeopleListViewModel _peopleListViewModel;

        public MainWindow(PeopleListViewModel peopleListViewModel)
        {
            _peopleListViewModel = peopleListViewModel;
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemPeoplesManagement":
                    Frame.Content = new PeoplesManagementPage(_peopleListViewModel);
                    break;
            }
        }
    }
}
