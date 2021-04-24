using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class AddColonyRequestDtoValidator : AbstractValidator<AddColonyRequestDto>
    {
        public AddColonyRequestDtoValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeGroupId).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeId).NotNull();
            RuleFor(x => x.MaxPopulation).NotEmpty();
            RuleFor(x => x.ActualPopulation).NotNull();
        }
    }
}
