using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators.System
{
    public class UpdateSystemDataTypeDtoValidator : AbstractValidator<UpdateSystemDataTypeRequestDto>
    {
        public UpdateSystemDataTypeDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
