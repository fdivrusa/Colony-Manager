using ColonyManager.Domain.Models.Account;
using FluentValidation;

namespace ColonyManager.Application.Validators.Account
{
    public class RegisterRequestDtoValidator : AbstractValidator<RegisterRequestDto>
    {
        public RegisterRequestDtoValidator()
        {
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.Password).NotNull().MinimumLength(10);
            RuleFor(x => x.ConfirmPassword).NotNull().Equal(x => x.Password);
            _ = RuleFor(x => x.AcceptTerms).Equals(true);
        }
    }
}
