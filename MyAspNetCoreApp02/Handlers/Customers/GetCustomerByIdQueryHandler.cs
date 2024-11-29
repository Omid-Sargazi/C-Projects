using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp02.Models;
using MyAspNetCoreApp02.Repository;
using MyAspNetCoreApp02.Requests.Customers;

namespace MyAspNetCoreApp02.Handlers.Customers
{
    public class GetCustomerByIdQueryHandler:IRequestHandler<GetCustomerByIdQuery,Customer>
    {
        public Task<Customer> Handle(GetCustomerByIdQuery request,CancellationToken cancellationToken)
        {
            var customer = CustomerRepository.GetCustomerById(request.CustomerId);
            if(customer==null)
            {
                throw new KeyNotFoundException($"Customer with ID {request.CustomerId} not found.");
            }
            return Task.FromResult(customer);
        }
    }
}