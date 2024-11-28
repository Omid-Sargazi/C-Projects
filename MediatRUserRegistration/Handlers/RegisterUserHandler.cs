using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRUserRegistration.Handlers
{
    public class RegisterUserHandler:IRequestHandler<RegisterUser,string>
    {
        public Task<string> Handle(RegisterUser request, CancellationToken cancellationToken)
        {
            var confirmationMessage = $"{request.Username} registered successfully with email{request.Email}";
        }
    }
}