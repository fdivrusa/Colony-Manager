using System.Security;
using System.Text.Json.Serialization;

namespace ColonyManager.Core.Models
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }

        [JsonIgnore]
        public SecureString SecurePassword { get; set; }
    }
}
