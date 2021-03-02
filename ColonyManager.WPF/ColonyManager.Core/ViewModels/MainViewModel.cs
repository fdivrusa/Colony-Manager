using Microsoft.Extensions.Logging;
using System.Windows;
using System.Windows.Input;

namespace ColonyManager.Core.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ILogger<MainViewModel> _logger;

        public MainViewModel(ILogger<MainViewModel> logger) : base(logger)
        {
            _logger = logger;
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (value != null)
                {
                    _email = value;
                    NotifyPropertyChanged(nameof(Email));
                }
            }
        }

        private string _role;

        public string Role
        {
            get { return _role; }
            set
            {
                if (value != null)
                {
                    _role = value;
                    NotifyPropertyChanged(nameof(Role));
                }
            }
        }

        private bool _isAdmin;

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                _isAdmin = value;
                NotifyPropertyChanged(nameof(IsAdmin));
            }
        }


        private ICommand _initializeMainViewModelCommand;

        public ICommand InitializeViewModelCommand
        {
            get
            {
                if (_initializeMainViewModelCommand == null)
                {
                    _initializeMainViewModelCommand = new RelayCommand<Window>(param => Initialize());
                }
                return _initializeMainViewModelCommand;
            }
        }

        private void Initialize()
        {
            _logger.LogDebug($"Initialize Main ViewModel for user with email {Email}");
            Email = Global.CurrentUser.Email;
            Role = Global.CurrentUser.Role;
            IsAdmin = Role == "Admin";
        }

        private ICommand _logoutCommand;

        public ICommand LogoutCommand
        {
            get
            {
                if (_logoutCommand == null)
                {
                    _logoutCommand = new RelayCommand<Window>(param => Logout(), canExecute => CanLogout());
                }
                return _logoutCommand;
            }
        }

        private bool CanLogout()
        {
            return true;
        }

        private void Logout()
        {
            _logger.LogDebug($"Logout for user with email {Email}");
            Application.Current.Shutdown();
        }
    }
}
