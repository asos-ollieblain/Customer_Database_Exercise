using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Queries.GetCustomerById;
using MediatR;

namespace Application.Queries.GetCanonicalCustomerById
{
    public class GetCanonicalCustomerByRequestHandler : IRequestHandler<GetCanonicalCustomerByIdRequest, GetCanonicalCustomerByIdResponse>
    {
        public Task<GetCanonicalCustomerByIdResponse> Handle(GetCanonicalCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
