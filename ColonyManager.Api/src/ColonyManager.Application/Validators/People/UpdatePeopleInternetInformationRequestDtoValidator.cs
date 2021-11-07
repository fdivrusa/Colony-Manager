using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators.People
{
    public class UpdatePeopleInternetInformationRequestDtoValidator : AbstractValidator<UpdatePeopleInternetInformationRequestDto>
    {
        public UpdatePeopleInternetInformationRequestDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.InternetInformationTypeId).NotEmpty();
            RuleFor(x => x.Value).NotEmpty();
        }
    }
}
