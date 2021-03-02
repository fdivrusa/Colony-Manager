using ColonyManager.Domain.Models;
using FluentValidation;

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
