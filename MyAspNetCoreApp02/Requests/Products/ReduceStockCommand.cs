using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp02.Requests.Products
{
    public class ReduceStockCommand:IRequest<string>
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}