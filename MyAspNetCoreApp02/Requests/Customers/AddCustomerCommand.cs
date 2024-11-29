using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp02.Requests.Customers
{
    public class AddCustomerCommand:IRequest<string>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}