using ColonyManager.Utility.Helpers;

namespace ColonyManager.Domain.Models.Account
{
    public class UpdateRequestDto
    {
        private string _password;
        private string _confirmPassword;
        private string _email;
        private string _role;

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Role
        {
            get => _role;
            set => _role = StringHelper.ReplaceEmptyWithNull(value);
        }

        public string Email
        {
            get => _email;
            set => _email = StringHelper.ReplaceEmptyWithNull(value);
        }

        public string Password
        {
            get => _password;
            set => _password = StringHelper.ReplaceEmptyWithNull(value);
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => _confirmPassword = StringHelper.ReplaceEmptyWithNull(value);

        }
    }
}
