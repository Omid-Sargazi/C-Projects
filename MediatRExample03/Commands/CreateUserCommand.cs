using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;


namespace MediatRExample03.Commands
{
    public class CreateUserCommand:IRequest<string>
    {
        public string UserName { get; set; }
    }
}