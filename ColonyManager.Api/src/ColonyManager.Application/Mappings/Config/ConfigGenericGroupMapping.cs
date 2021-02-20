using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class ConfigGenericGroupMapping : Profile
    {
        public ConfigGenericGroupMapping()
        {
            CreateMap<ConfigGenericGroup, ConfigGenericGroupDto>()
                .ReverseMap();

            CreateMap<ConfigGenericGroup, ConfigGenericGroupDetailedDto>()
                .ReverseMap();

            CreateMap<AddConfigGenericGroupDto, ConfigGenericGroup>();

            CreateMap<UpdateConfigGenericGroupRequestDto, ConfigGenericGroup>();
        }
    }
}
