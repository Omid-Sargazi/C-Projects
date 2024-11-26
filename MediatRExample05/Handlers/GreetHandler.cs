using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

using MediatRExample05.Requests;

namespace MediatRExample05.Handlers
{
    public class GreetHandler:IRequestHandler<Greet,string>
    {
        public Task<string> Handle(Greet request,CancellationToken cancellationToken)
        {
            var message = $"Hello,{request.Name}";
            return Task.FromResult(message);
        }
    }
}