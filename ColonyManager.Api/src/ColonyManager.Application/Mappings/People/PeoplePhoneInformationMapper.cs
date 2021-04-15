using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class PeoplePhoneInformationMapper : Profile
    {
        public PeoplePhoneInformationMapper()
        {
            CreateMap<PeoplePhoneInformation, PeoplePhoneInformationDto>()
                .ForMember(x => x.TypeCode, opt => opt.MapFrom(y => y.Type.Code))
                .ForMember(x => x.TypeDescription, opt => opt.MapFrom(y => y.Type.Description))
                .ReverseMap();

            CreateMap<AddPeoplePhoneRequestDto, PeoplePhoneInformation>();

            CreateMap<UpdatePeoplePhoneRequestDto, PeopleInternetInformation>();
        }
    }
}
