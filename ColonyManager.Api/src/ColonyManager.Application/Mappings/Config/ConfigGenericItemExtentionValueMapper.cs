using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class ConfigGenericItemExtentionValueMapper : Profile
    {
        public ConfigGenericItemExtentionValueMapper()
        {
            CreateMap<ConfigGenericItemExtensionValue, ConfigGenericItemExtentionValueDto>()
                .ReverseMap();

            CreateMap<AddConfigGenericItemExtentionValueRequestDto, ConfigGenericItemExtensionValue>();

            CreateMap<UpdateConfigGenericItemExtentionValueRequestDto, ConfigGenericItemExtensionValue>();
        }
    }
}
