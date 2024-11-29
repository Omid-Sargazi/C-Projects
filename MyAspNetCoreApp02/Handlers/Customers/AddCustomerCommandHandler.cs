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
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, string>
    {
        public Task<string> Handle(AddCustomerCommand request,CancellationToken cancellationToken)
        {
            var newCustomer = new Customer
            {
                Id=Guid.NewGuid(),
                Name=request.Name,
                Email=request.Email,
            };
            CustomerRepository.AddCustomer(newCustomer);
            return Task.FromResult($"Customer '{newCustomer.Name}' added successfully with ID: {newCustomer.Id}");
        }
    }
}