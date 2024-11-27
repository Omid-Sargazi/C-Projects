using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, string>
    {
        public Task<string> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var updatedPerson = new Pesron
            {
                Id=request.Id,
                FirstName=request.FirstName,
                LastName=request.LastName,
                Age=request.Age,
            };
            return Task.FromResult($"Person {updatedPerson.Id} updated successfully!");
        }
    }
}