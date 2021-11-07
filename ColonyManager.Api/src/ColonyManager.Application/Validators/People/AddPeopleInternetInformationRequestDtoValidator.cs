using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators
{
    public class AddPeopleInternetInformationRequestDtoValidator : AbstractValidator<AddPeopleInternetInformationRequestDto>
    {
        public AddPeopleInternetInformationRequestDtoValidator()
        {
            RuleFor(x => x.PeopleId).NotEmpty();
            RuleFor(x => x.InternetInformationTypeId).NotEmpty();
            RuleFor(x => x.Value).NotEmpty();
        }
    }
}
