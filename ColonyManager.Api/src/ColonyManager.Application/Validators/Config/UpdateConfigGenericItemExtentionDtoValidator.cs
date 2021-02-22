using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class UpdateConfigGenericItemExtentionDtoValidator : AbstractValidator<UpdateConfigGenericItemExtentionRequestDto>
    {
        public UpdateConfigGenericItemExtentionDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.GroupId).NotEmpty();
            RuleFor(x => x.ItemId).NotEmpty();
        }
    }
}
