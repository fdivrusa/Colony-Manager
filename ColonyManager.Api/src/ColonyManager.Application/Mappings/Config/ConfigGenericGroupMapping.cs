using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;
using ColonyManager.Domain.Models.Config;

namespace ColonyManager.Application.Mappings.Config
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
