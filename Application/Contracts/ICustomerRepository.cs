using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Application.Contracts
{
    public interface ICustomerRepository
    {
        CustomerModel GetCustomerById(int id);
    }
}
