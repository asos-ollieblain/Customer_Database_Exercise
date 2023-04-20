using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Queries.GetCustomerById
{
    public partial class GetCustomerByIdResponse
    {
        public CustomerModel Customer { get; set; } = new();
    }
}
