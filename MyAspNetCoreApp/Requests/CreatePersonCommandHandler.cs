using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Requests
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, string>
    {
        public Task<string> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Person {request.FirstName} {request.LastName} created successfully!");
        }
    }
}