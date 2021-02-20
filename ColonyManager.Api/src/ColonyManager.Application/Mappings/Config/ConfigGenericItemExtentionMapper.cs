using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class ConfigGenericItemExtentionMapper : Profile
    {
        public ConfigGenericItemExtentionMapper()
        {
            CreateMap<ConfigGenericItemExtension, ConfigGenericItemExtentionDto>()
                .ReverseMap();

            CreateMap<AddConfigGenericItemExtentionRequestDto, ConfigGenericItemExtension>();

            CreateMap<UpdateConfigGenericItemExtentionRequestDto, ConfigGenericItemExtension>();
        }
    }
}
