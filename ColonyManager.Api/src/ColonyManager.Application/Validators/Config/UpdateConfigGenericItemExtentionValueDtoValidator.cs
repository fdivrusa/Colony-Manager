using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class UpdateConfigGenericItemExtentionValueDtoValidator : AbstractValidator<UpdateConfigGenericItemExtentionValueRequestDto>
    {
        public UpdateConfigGenericItemExtentionValueDtoValidator()
        {
            RuleFor(x => x.GroupId).NotEmpty();
            RuleFor(x => x.ItemId).NotEmpty();
            RuleFor(x => x.ExentionId).NotEmpty();
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
