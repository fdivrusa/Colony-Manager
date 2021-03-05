using ColonyManager.Core.Helpers;
using ColonyManager.Core.Models;
using ColonyManager.Core.Services.Interfaces;
using ColonyManager.Global;
using ColonyManager.Provider.Responses;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ColonyManager.Core.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly IAccountService _accountService;
        private readonly ILogger<LoginViewModel> _logger;

        public LoginViewModel(IAccountService accountService, ILogger<LoginViewModel> logger) : base(logger)
        {
            _accountService = accountService;
            _logger = logger;
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    ValidateEmail();
                    NotifyPropertyChanged(nameof(Email));
                }
            }
        }

        private SecureString _password;

        public SecureString Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    NotifyPropertyChanged(nameof(Password));
                }
            }
        }

        private void ValidateEmail()
        {
            ClearErrors(nameof(Email));
            if (string.IsNullOrWhiteSpace(Email))
            {
                AddError(nameof(Email), "Email cannot be empty");
            }

            if (!EmailHelper.IsEmailValid(Email))
            {
                AddError(nameof(Email), "Email is not valid");
            }
        }

        private ICommand _authenticateCommand;

        public ICommand AuthenticateCommand
        {
            get
            {
                if (_authenticateCommand == null)
                {
                    _authenticateCommand = new RelayCommand<Window>(async param => await Authenticate(), canExecute => CanAuthenticate());
                }
                return _authenticateCommand;
            }
        }

        private bool CanAuthenticate()
        {
            if (GetErrors(nameof(Email)) == null)
            {
                return true;
            }

            return !GetErrors(nameof(Email)).Cast<object>().Any();
        }

        private async Task Authenticate()
        {
            if (!string.IsNullOrEmpty(Email) && Password != null)
            {
                _logger.LogDebug($"Begin Authentication for user with email {Email}");

                var response = await _accountService.AuthenticateAsync(new LoginRequest
                {
                    Email = Email,
                    SecurePassword = Password
                });

                if (response != null)
                {
                    //Check that the user is verified
                    if (response.Success)
                    {
                        if (response.IsVerified)
                        {
                            _logger.LogDebug("Account is verified and loggin is valid");

                            //User is verified, store user informations in Global and close
                            StoreGlobalUserInformations(response);
                            RaiseLoginCompletedEvent();
                        }
                        else
                        {
                            _logger.LogDebug($"Account with Email {Email} is not verified but tries to connect");

                            //User is not verified, display error message
                            MessageBox.Show("Your account is not verified, please contact your administrator");
                        }
                    }
                    else
                    {
                        ShowErrorAndLogMessage(Global.Enums.ErrorLevel.Error, "Login response error", $"An error occured during the login for user with email {Email}. \nError : {response.ErrorMessage}");
                    }
                }
                else
                {
                    ShowErrorAndLogMessage(Global.Enums.ErrorLevel.Error, "Unknown Error", $"An unknown error occured during the login for user with email {Email}");
                }
            }
        }

        public event EventHandler LoginCompleted;
        private void RaiseLoginCompletedEvent()
        {
            LoginCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void StoreGlobalUserInformations(AuthenticationResponse response)
        {
            CurrentUser.Id = response.Id;
            CurrentUser.Title = response.Title;
            CurrentUser.FirstName = response.FirstName;
            CurrentUser.LastName = response.LastName;
            CurrentUser.Email = response.Email;
            CurrentUser.Role = response.Role;
            CurrentUser.CreatedDate = response.CreatedDate;
            CurrentUser.IsVerified = response.IsVerified;
            CurrentUser.JwtToken = response.JwtToken;
        }
    }
}
