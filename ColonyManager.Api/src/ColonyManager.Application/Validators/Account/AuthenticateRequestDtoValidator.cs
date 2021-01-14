using ColonyManager.Domain.Models.Account;
using FluentValidation;

namespace ColonyManager.Application.Validators.Account
{
    public class AuthenticateRequestDtoValidator : AbstractValidator<AuthenticateRequestDto>
    {
        public AuthenticateRequestDtoValidator()
        {
            RuleFor(x => x.Password).NotNull();
            RuleFor(x => x.Email).EmailAddress().NotNull();
        }
    }
}
