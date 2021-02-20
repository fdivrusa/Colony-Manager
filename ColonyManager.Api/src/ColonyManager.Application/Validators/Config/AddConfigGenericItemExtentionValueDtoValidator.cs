using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class AddConfigGenericItemExtentionValueDtoValidator : AbstractValidator<AddConfigGenericItemExtentionValueRequestDto>
    {
        public AddConfigGenericItemExtentionValueDtoValidator()
        {
            RuleFor(x => x.GroupId).NotEmpty();
            RuleFor(x => x.ItemId).NotEmpty();
            RuleFor(x => x.ExtentionId).NotEmpty();
            RuleFor(x => x.Code).NotEmpty();
            RuleFor(x => x.Value).NotEmpty();
        }
    }
}
