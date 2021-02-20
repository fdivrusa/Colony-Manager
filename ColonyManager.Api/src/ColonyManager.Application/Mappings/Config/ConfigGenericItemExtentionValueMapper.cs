using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class ConfigGenericItemExtentionValueMapper : Profile
    {
        public ConfigGenericItemExtentionValueMapper()
        {
            CreateMap<ConfigGenericItemExtentionValueDto, ConfigGenericItemExtensionValue>()
                .ReverseMap();

            CreateMap<AddConfigGenericItemExtentionValueRequestDto, ConfigGenericItemExtensionValue>();
        }
    }
}
