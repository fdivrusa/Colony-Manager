using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class NationalityMapper : Profile
    {
        public NationalityMapper()
        {
            CreateMap<Nationality, NationalityDto>()
                .ReverseMap();

            CreateMap<AddNationalityRequestDto, Nationality>()
                .ReverseMap();
        }
    }
}
