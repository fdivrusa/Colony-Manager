using ColonyManager.Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Application.Validators
{
    public class UpdatePeopleRequestDtoValidator : AbstractValidator<UpdatePeopleRequestDto>
    {
        public UpdatePeopleRequestDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.BirthDate).NotEmpty();
            RuleFor(x => x.IsActive).NotEmpty();
            RuleFor(x => x.Deceased).NotEmpty();
        }
    }
}
