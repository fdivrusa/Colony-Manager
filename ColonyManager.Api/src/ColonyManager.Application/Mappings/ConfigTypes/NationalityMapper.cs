using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings.ConfigTypes
{
    public class NationalityMapper : Profile
    {
        public NationalityMapper()
        {
            CreateMap<Nationality, NationalityDto>()
                .ReverseMap();
        }
    }
}
