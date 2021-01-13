using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models.Account;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Application.Validators.Account
{
    public class UpdateRequestDtoValidator : AbstractValidator<UpdateRequestDto>
    {
        public UpdateRequestDtoValidator()
        {
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Password).MinimumLength(10);
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password);
            RuleFor(x => x.Role).IsInEnum();
        }
    }
}
