using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Queries.GetCanonicalCustomerById;
using MediatR;

namespace Application.Queries.GetCanonicalCustomerById
{
    public class GetCanonicalCustomerByIdRequest : IRequest<GetCanonicalCustomerByIdResponse>
    {

    }
}
