using ColonyManager.Domain.Models.Account;
using FluentValidation;

namespace ColonyManager.Application.Validators.Account
{
    public class CreateAccountRequestDtoValidator : AbstractValidator<CreateAccountRequestDto>
    {
        public CreateAccountRequestDtoValidator()
        {
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.Email).NotNull();
            RuleFor(x => x.Password).NotNull().MinimumLength(10);
            RuleFor(x => x.ConfirmPassword).NotNull().Equal(x => x.Password);
        }
    }
}
