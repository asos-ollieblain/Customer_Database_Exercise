using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Queries.GetCanonicalCustomerById;
using MediatR;

namespace Application.Queries.GetCustomerById
{
    public class GetCustomerByIdRequest : IRequest<GetCanonicalCustomerByIdResponse>, IRequest<GetCustomerByIdResponse>
    {

    }
}
