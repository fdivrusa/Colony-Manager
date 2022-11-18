using ColonyManager.Domain.Models;
using FluentValidation;

namespace ColonyManager.Application.Validators.People
{
    public class AddPeopleAddressRequestDtoValidator : AbstractValidator<AddPeopleAddressRequestDto>
    {
        public AddPeopleAddressRequestDtoValidator()
        {
            RuleFor(x => x.PeopleId).NotEmpty();
            RuleFor(x => x.CountryId).NotEmpty();
            RuleFor(x => x.AddressTypeId).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.StreetName).NotEmpty();
            RuleFor(x => x.Number).NotEmpty();
        }
    }
}
