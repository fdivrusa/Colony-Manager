using ColonyManager.Domain.Models.Account;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Application.Validators.Account
{
    public class VerifyEmailRequestDtoValidator : AbstractValidator<VerifyEmailRequestDto>
    {
        public VerifyEmailRequestDtoValidator()
        {
            RuleFor(x => x.Token).NotEmpty();
        }
    }
}
