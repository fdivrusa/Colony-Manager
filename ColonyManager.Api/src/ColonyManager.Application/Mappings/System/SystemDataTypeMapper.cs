using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class SystemDataTypeMapper : Profile
    {
        public SystemDataTypeMapper()
        {
            CreateMap<SystemDataTypeDto, SystemDataType>()
                .ReverseMap();

            CreateMap<AddSystemDataTypeRequestDto, SystemDataType>();

            CreateMap<UpdateSystemDataTypeRequestDto, SystemDataType>();
        }
    }
}
