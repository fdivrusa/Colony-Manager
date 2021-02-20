using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class UpdateConfigGenericGroupDtoValidator : AbstractValidator<UpdateConfigGenericGroupRequestDto>
    {
        public UpdateConfigGenericGroupDtoValidator()
        {
            RuleFor(x => x.GroupId).NotNull();
            RuleFor(x => x.Description).NotNull();
        }
    }
}
