using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Queries.GetCanonicalCustomerById
{
    public class GetCanonicalCustomerByIdResponse
    {
        public CanonicalCustomerModel Customer { get; set; } = new();
    }
}
