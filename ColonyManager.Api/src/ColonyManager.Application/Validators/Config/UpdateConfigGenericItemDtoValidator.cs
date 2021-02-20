using ColonyManager.Domain.Models.Config;
using FluentValidation;

namespace ColonyManager.Application.Validators.Config
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
