using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class AddPeoplePhoneRequestDtoValidator : AbstractValidator<AddPeoplePhoneRequestDto>
    {
        public AddPeoplePhoneRequestDtoValidator()
        {
            RuleFor(x => x.PeopleId).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeGroupId).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeId).NotEmpty();
            RuleFor(x => x.Value).NotEmpty();
        }
    }
}
