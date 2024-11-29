using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp02.Models;

namespace MyAspNetCoreApp02.Requests.Customers
{
    public class GetCustomerByIdQuery:IRequest<Customer>
    {
        public Guid CustomerID { get; set; }
    }
}