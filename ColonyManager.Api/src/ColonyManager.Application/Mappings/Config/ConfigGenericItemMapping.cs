using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings.Config
{
    public class ConfigGenericItemMapping : Profile
    {
        public ConfigGenericItemMapping()
        {
            CreateMap<ConfigGenericItem, ConfigGenericItemDto>()
                .ReverseMap();
        }
    }
}
