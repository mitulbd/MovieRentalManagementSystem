﻿using AutoMapper;
using MovieRentalManagementSystem.Dtos;
using MovieRentalManagementSystem.Models;

namespace MovieRentalManagementSystem.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}