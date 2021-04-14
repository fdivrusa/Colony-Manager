using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class AddPeopleInternetInformationRequestDtoValidator : AbstractValidator<AddPeopleInternetInformationRequestDto>
    {
        public AddPeopleInternetInformationRequestDtoValidator()
        {
            RuleFor(x => x.PeopleId).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeGroupId).NotEmpty();
            RuleFor(x => x.ConfigGenericTypeId).NotEmpty();
            RuleFor(x => x.Value).NotEmpty();
        }
    }
}
