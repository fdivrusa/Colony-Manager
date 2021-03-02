using ColonyManager.Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Application.Validators
{
    public class AddPeopleRequestDtoValidator : AbstractValidator<AddPeopleRequestDto>
    {
        public AddPeopleRequestDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.BirthDate).NotEmpty();
        }
    }
}
