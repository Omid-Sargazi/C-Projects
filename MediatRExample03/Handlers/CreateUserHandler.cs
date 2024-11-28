using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRExample03.Commands;


namespace MediatRExample03.Handlers
{
    public class CreateUserHandler:IRequestHandler<CreateUserCommand, string>
    {
        public Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            string result = $"User '{request.UserName}' created successfully!";
            return Task.FromResult(result);
        }
    }
}