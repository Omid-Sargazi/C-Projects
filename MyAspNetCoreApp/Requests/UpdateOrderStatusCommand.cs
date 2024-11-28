using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp.Requests
{
    public class UpdateOrderStatusCommand:IRequest<string>
    {
        public int Id { get; set; }
        public string NewStatus { get; set; }
    }
}