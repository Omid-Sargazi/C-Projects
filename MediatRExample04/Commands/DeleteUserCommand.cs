using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRExample04.Handlers;

namespace MediatRExample04.Commands
{
    public class DeleteUserCommand:IRequest<string>
    {
        public string UserName { get; set; }
    }
}