using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts;
using AutoMapper;
using Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(CustomerDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CustomerModel GetCustomerById(int id)
        {
            var customer = _context.Customers.Include(x => x.Address).Include(x => x.Contact).Single(X => X.Id == id);
            var customerModel = _mapper.Map<CustomerModel>(customer);
            return customerModel;
        }
    }
}
