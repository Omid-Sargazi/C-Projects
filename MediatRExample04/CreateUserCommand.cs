using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using MediatR;

namespace MediatRExample04
{
    public class CreateUserCommand : IRequest<string>
{
    public string UserName { get; set; }
}
}