using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRExample04.Commands;

namespace MediatRExample04.Handlers
{
    public class DeleteUserHandler:IRequestHandler<DeleteUserCommand,string>
    {
        public Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"User '{request.UserName}' deleted successfully.");
        }
    }
}