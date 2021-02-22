using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class AddConfigGenericGroupDtoValidator : AbstractValidator<AddConfigGenericGroupDto>
    {
        public AddConfigGenericGroupDtoValidator()
        {
            RuleFor(x => x.Code).NotNull().MaximumLength(64);
            RuleFor(x => x.RelatedSubject).NotNull().MaximumLength(64);
        }
    }
}
