using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyAspNetCoreApp02.Requests
{
    public class UpdateProductPriceCommand:IRequest<string>
    {
        public int ProductId { get; set; }
        public decimal NewPrice { get; set; }
    }
}