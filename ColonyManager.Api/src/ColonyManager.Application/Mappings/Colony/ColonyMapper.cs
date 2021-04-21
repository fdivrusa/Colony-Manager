using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class ColonyMapper : Profile
    {
        public ColonyMapper()
        {
            CreateMap<Colony, ColonyDto>()
                .ForMember(x => x.TypeCode, opt => opt.MapFrom(x => x.Code))
                .ForMember(x => x.TypeDescription, opt => opt.MapFrom(x => x.Description))
                .ReverseMap();
        }
    }
}
