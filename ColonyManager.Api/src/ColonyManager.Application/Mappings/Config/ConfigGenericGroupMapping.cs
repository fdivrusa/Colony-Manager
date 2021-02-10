using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings.Config
{
    public class ConfigGenericGroupMapping : Profile
    {
        public ConfigGenericGroupMapping()
        {
            CreateMap<ConfigGenericGroup, ConfigGenericGroupDto>()
                .ReverseMap();
        }
    }
}
