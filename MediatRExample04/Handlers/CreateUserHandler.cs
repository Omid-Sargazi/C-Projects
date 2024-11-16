using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using System.Threading;
using MediatRExample04.Commands;

namespace MediatRExample04.Handlers
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