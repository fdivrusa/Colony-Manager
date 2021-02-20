using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;
using ColonyManager.Domain.Models.Config;

namespace ColonyManager.Application.Mappings.Config
{
    public class ConfigGenericItemMapping : Profile
    {
        public ConfigGenericItemMapping()
        {
            CreateMap<ConfigGenericItem, ConfigGenericItemDto>()
                .ReverseMap();

            CreateMap<AddConfigGenericItemRequestDto, ConfigGenericItem>();

            CreateMap<UpdateConfigGenericItemRequestDto, ConfigGenericItem>();
        }
    }
}
