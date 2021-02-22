using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class AddSystemDataTypeDtoValidator : AbstractValidator<AddSystemDataTypeRequestDto>
    {
        public AddSystemDataTypeDtoValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
            RuleFor(x => x.IsList).NotNull();
        }
    }
}
