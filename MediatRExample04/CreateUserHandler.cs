using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using System.Threading;

namespace MediatRExample04
{
   public class CreateUserHandler : IRequestHandler<CreateUserCommand, string>
{
    public Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Simulate creating a user
        return Task.FromResult($"User '{request.UserName}' created successfully!");
    }
}
}