using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators.ParamConfig
{
    public class AddNationalityRequestValidator : AbstractValidator<AddNationalityRequestDto>
    {
        public AddNationalityRequestValidator()
        {
            RuleFor(x => x.Code).NotNull().MinimumLength(1).MaximumLength(128);
            RuleFor(x => x.Description).NotNull().MinimumLength(1).MaximumLength(512);
        }
    }
}
