using ColonyManager.Domain.Models.Account;
using FluentValidation;

namespace ColonyManager.Application.Validators.Account
{
    public class VerifyEmailRequestDtoValidator : AbstractValidator<VerifyEmailRequestDto>
    {
        public VerifyEmailRequestDtoValidator()
        {
            RuleFor(x => x.Token).NotEmpty();
        }
    }
}
