using AutoMapper;
using CRMUpSchool.DTOLayer.ContactDTOs;
using CRMUpSchool.DTOLayer.CustomerDTOs;
using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<ContactAddDTO, Contact>();
            CreateMap<Contact, ContactAddDTO>();

            CreateMap<ContactUpdateDTO, Contact>();
            CreateMap<Contact, ContactUpdateDTO>();

            CreateMap<ContactListDTO, Contact>();
            CreateMap<Contact, ContactListDTO>();

            CreateMap<CustomerAddDTO, Customer>();
            CreateMap<Customer, CustomerAddDTO>();
        }
    }
}
