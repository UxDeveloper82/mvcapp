﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            // Dto  to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c=> c.Id, opt => opt.Ignore());
        }
    }
}