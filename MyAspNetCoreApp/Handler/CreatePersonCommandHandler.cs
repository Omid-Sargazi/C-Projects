using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand02, string>
    {
        public Task<string> Handle(CreatePersonCommand02 request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Person {request.FirstName} {request.LastName} created successfully!!!!!");
        }
    }
}