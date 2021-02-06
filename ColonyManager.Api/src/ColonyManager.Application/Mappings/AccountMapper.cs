using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models.Account;

namespace ColonyManager.Application.Mappings
{
    public class AccountMapper : Profile
    {
        public AccountMapper()
        {
            CreateMap<Account, AccountResponseDto>();

            CreateMap<Account, AuthenticateResponseDto>();

            CreateMap<RegisterRequestDto, Account>();

            CreateMap<CreateAccountRequestDto, Account>();

            CreateMap<UpdateRequestDto, Account>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore null & empty string properties
                        if (prop == null) return false;
                        if ((prop is string @string) && string.IsNullOrEmpty(@string)) return false;

                        // ignore null role
                        if (x.DestinationMember.Name == "Role" && src.Role == null) return false;

                        return true;
                    }
                ));
        }
    }
}
