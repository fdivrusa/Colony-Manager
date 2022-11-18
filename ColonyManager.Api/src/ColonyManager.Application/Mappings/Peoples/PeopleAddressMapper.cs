using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;

namespace ColonyManager.Application.Mappings
{
    public class PeopleAddressMapper : Profile
    {
        public PeopleAddressMapper()
        {
            CreateMap<PeopleAddress, PeopleAddressDto>()
                .ForMember(x => x.CountryCode, opt => opt.MapFrom(y => y.Country.AlphaCode2))
                .ForMember(x => x.CountryDescription, opt => opt.MapFrom(y => y.Country.Description))
                .ForMember(x => x.AddressTypeCode, opt => opt.MapFrom(y => y.Type.Code))
                .ForMember(x => x.AddressTypeDescription, opt => opt.MapFrom(y => y.Type.Description))
                .ReverseMap();
        }
    }
}
