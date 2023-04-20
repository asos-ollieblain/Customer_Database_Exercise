using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data.Models;
using Domain.Models;

namespace Infrastructure.Mapper
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            CreateMap<CustomerModel, Customer>().ReverseMap();
            CreateMap<AddressModel, Address>().ReverseMap();
            CreateMap<ContactModel, Contact>().ReverseMap();

        }
    }
}
