using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators.Config
{
    public class AddConfigGenericItemExtentionDtoValidator : AbstractValidator<AddConfigGenericItemExtentionRequestDto>
    {
        public AddConfigGenericItemExtentionDtoValidator()
        {
            RuleFor(x => x.GroupId).NotNull();
            RuleFor(x => x.ItemId).NotNull();
            RuleFor(x => x.SystemDataTypeId).NotNull();
            RuleFor(x => x.Code).NotNull();
        }
    }
}
