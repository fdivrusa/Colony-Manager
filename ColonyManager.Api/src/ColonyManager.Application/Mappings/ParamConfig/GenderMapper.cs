using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class GenderMapper : Profile
    {
        public GenderMapper()
        {
            CreateMap<Gender, GenderDto>()
                .ReverseMap();
        }
    }
}
