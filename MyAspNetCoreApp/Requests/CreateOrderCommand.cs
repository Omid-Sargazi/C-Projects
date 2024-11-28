using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp.Requests
{
    public class CreateOrderCommand:IRequest<string>
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}