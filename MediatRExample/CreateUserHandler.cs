using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using MediatR;

namespace MediatRExample
{
    public class CreateUserHandler:IRequestHandler<CreateUserCommand, string>
    {
        public Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"User '{request.UserName}' created successfully!");
        }
    }
}