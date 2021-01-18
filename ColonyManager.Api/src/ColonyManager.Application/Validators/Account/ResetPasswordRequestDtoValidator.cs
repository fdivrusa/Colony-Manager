using ColonyManager.Domain.Models.Account;
using FluentValidation;

namespace ColonyManager.Application.Validators.Account
{
    public class ResetPasswordRequestDtoValidator : AbstractValidator<ResetPasswordRequestDto>
    {
        public ResetPasswordRequestDtoValidator()
        {
            RuleFor(x => x.Token).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(10);
            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.ConfirmPassword);
        }
    }
}
