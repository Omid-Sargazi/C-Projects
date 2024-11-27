using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Models;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class GetPersonQueryHandler : IRequestHandler<GetPersonQuery, Pesron>
    {
        public Task<Pesron> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
            var person = new Pesron
            {
                Id=request.Id,
                FirstName="Omid",
                LastName="sargazi",
                Age=42,
            };
            return Task.FromResult(person);
        }
    }
}