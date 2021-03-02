using AutoMapper;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Application.Mappings
{
    public class PeopleMapper : Profile
    {
        public PeopleMapper()
        {
            CreateMap<People, PeopleDto>()
                .ForMember(x => x.GenderCode, opt => opt.MapFrom(y => y.Gender.Code))
                .ForMember(x => x.GenderDescription, opt => opt.MapFrom(y => y.Gender.Description))
                .ForMember(x => x.ProfessionCode, opt => opt.MapFrom(y => y.Profession.Code))
                .ForMember(x => x.ProfessionDescription, opt => opt.MapFrom(y => y.Profession.Description))
                .ReverseMap();

            CreateMap<AddPeopleRequestDto, People>();

            CreateMap<UpdatePeopleRequestDto, People>();
        }
    }
}
