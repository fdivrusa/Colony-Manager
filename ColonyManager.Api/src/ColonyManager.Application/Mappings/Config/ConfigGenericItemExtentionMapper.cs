using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;
using ColonyManager.Domain.Models.Config;

namespace ColonyManager.Application.Mappings.Config
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
