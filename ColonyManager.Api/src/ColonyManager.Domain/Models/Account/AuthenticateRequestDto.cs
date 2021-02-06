namespace ColonyManager.Domain.Models.Account
{
    public class AuthenticateRequestDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
