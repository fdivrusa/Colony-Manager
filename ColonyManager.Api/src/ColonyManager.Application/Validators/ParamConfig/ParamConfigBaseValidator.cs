using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators.ParamConfig
{
    public class ParamConfigBaseValidator<T> : AbstractValidator<T> where T : ParamConfigBaseDto
    {
        public ParamConfigBaseValidator()
        {
            RuleFor(x => x.Code).NotNull().MinimumLength(1).MaximumLength(128);
            RuleFor(x => x.Description).NotNull().MinimumLength(1).MaximumLength(512);
        }
    }
}
