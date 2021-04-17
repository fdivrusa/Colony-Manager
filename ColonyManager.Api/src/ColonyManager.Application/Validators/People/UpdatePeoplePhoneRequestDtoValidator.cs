﻿using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class UpdatePeoplePhoneRequestDtoValidator : AbstractValidator<UpdatePeoplePhoneRequestDto>
    {
        public UpdatePeoplePhoneRequestDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeGroupId).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeId).NotEmpty();
            RuleFor(x => x.Value).NotEmpty();
            RuleFor(x => x.IsObsolete).NotEmpty();
        }
    }
}
