using ColonyManager.Core.ViewModels;
using System.Windows.Controls;

namespace ColonyManager.WPF.Pages
{
    /// <summary>
    /// Interaction logic for PeoplesManagementPage.xaml
    /// </summary>
    public partial class PeoplesManagementPage : Page
    {
        public PeoplesManagementPage(PeopleListViewModel peopleListViewModel)
        {
            InitializeComponent();
            DataContext = peopleListViewModel;
        }
    }
}
