using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class PeopleInternetInformationMapper : Profile
    {
        public PeopleInternetInformationMapper()
        {
            CreateMap<PeopleInternetInformation, PeopleInternetInformationDto>()
                .ForMember(x => x.TypeCode, opt => opt.MapFrom(y => y.Type.Code))
                .ForMember(x => x.TypeDescription, opt => opt.MapFrom(y => y.Type.Description))
                .ReverseMap();

            CreateMap<AddPeopleInternetInformationRequestDto, People>();

            CreateMap<UpdatePeopleInternetInformationRequestDto, People>();
        }
    }
}
