using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Queries.GetCanonicalCustomerById;
using Application.Queries.GetCustomerById;
using MediatR;

namespace Application.Queries.GetCustomerById
{
    public class GetCustomerByRequestHandler : IRequestHandler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        public Task<GetCustomerByIdResponse> Handle(GetCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
