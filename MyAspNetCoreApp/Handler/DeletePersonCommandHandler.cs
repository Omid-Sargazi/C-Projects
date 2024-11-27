using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp.Requests;

namespace MyAspNetCoreApp.Handler
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, string>
    {
        public Task<string> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Person {request.Id} deleted successfully!");
        }
    }
}