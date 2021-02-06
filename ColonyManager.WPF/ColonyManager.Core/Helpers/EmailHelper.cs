using System.Text.RegularExpressions;

namespace ColonyManager.Core.Helpers
{
    public static class EmailHelper
    {
        public static bool IsEmailValid(string email)
        {
            return (Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"));
        }
    }
}
