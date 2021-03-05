using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class PeopleMapper : Profile
    {
        public PeopleMapper()
        {
            CreateMap<People, PeopleDetailedDto>()
                .ForMember(x => x.GenderCode, opt => opt.MapFrom(y => y.Gender == null ? string.Empty : y.Gender.Code))
                .ForMember(x => x.GenderDescription, opt => opt.MapFrom(y => y.Gender == null ? string.Empty : y.Gender.Description))
                .ForMember(x => x.ProfessionCode, opt => opt.MapFrom(y => y.Profession == null ? string.Empty : y.Profession.Code))
                .ForMember(x => x.ProfessionDescription, opt => opt.MapFrom(y => y.Profession == null ? string.Empty : y.Profession.Description))
                .ReverseMap();

            CreateMap<AddPeopleRequestDto, People>();

            CreateMap<UpdatePeopleRequestDto, People>();
        }
    }
}
