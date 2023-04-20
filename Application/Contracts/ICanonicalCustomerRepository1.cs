using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Contracts
{
    public interface ICanonicalCustomerRepository
    {
        CanonicalCustomerModel GetById(int id);
        CanonicalCustomerModel Create(CanonicalCustomerModel canonicalCustomerModel);  
        CanonicalCustomerModel Update(CanonicalCustomerModel canonicalCustomerModel);
    }
}
