using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MediatRUserRegistration.Requests
{
    public class RegisterUser:IRequest<string>
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public RegisterUser(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }
    }
}