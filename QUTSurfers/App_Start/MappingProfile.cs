using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using QUTSurfers.Dtos;
using QUTSurfers.Models;

namespace QUTSurfers.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Members, MemberDto>();
            Mapper.CreateMap<MemberDto, Members>();
            Mapper.CreateMap<Payment, PaymentDto>();
            Mapper.CreateMap<LevelOfSurfing, LevelOfSurfingDto>();
        }
    }
}