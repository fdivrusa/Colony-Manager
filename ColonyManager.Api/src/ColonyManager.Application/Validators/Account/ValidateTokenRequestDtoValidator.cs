using ColonyManager.Domain.Models.Account;
using FluentValidation;

namespace ColonyManager.Application.Validators.Account
{
    public class ValidateTokenRequestDtoValidator : AbstractValidator<ValidateResetTokenRequestDto>
    {
        public ValidateTokenRequestDtoValidator()
        {
            RuleFor(x => x.Token).NotEmpty();
        }
    }
}
