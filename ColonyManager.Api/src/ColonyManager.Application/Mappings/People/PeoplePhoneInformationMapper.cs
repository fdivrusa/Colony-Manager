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
                .ReverseMap();
        }
    }
}
