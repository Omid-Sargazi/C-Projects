using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand02, string>
    {
        public Task<string> Handle(CreatePersonCommand02 request, CancellationToken cancellationToken)
        {
            var newPerson = new Pesron
            {
                FirstName=request.FirstName,
                LastName=request.LastName,
                Age=request.Age,
            };
            return Task.FromResult($"Person {newPerson.FirstName} {newPerson.LastName} created successfully!");
        }
    }
}