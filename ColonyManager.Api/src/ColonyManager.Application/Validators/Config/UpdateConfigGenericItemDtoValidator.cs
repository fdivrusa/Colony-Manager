using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class UpdateConfigGenericItemDtoValidator : AbstractValidator<UpdateConfigGenericItemRequestDto>
    {
        public UpdateConfigGenericItemDtoValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.GroupId).NotNull();
        }
    }
}
