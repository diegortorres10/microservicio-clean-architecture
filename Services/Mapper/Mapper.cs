using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;
using static Services.ViewModels.CommonModel;

namespace Services.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            AllowNullDestinationValues = true;
            //Source -> Destination
            CreateMap<Client, ClientModel>()
                .ForMember(dto => dto.ClientId, opt => opt.MapFrom(src => src.ClientId))
                .ForMember(dto => dto.PersonName, opt => opt.MapFrom(src => src.Person.Name));
        }
    }
}
