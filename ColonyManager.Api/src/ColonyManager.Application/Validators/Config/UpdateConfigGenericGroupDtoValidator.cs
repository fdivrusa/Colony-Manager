using ColonyManager.Domain.Models.Config;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Application.Validators.Config
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
