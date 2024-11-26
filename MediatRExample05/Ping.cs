using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MediatRExample05
{
    public class Ping:IRequest<string>
    {
        
    }

    public class Ping2:IRequest<int>
    {}

    class PingHandler:IRequestHandler<Ping,string>
    {
        public Task<string> Handle(Ping request,CancellationToken cancellationToken)
        {
            return Task.FromResult("request");
        }
    }
}