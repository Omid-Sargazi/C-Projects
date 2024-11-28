using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp02.Requests;

namespace MyAspNetCoreApp02.Handlers
{
    public class UpdateProductPriceCommandHandler : IRequestHandler<UpdateProductPriceCommand, string>
    {
        private static readonly Dictionary<int, decimal> _productPrices = new ()
        {
            {1,100.00m},
            {2,200.00m},
            {3,300.00m},
        };


        public Task<string> Handle(UpdateProductPriceCommand request, CancellationToken cancellationToken)
        {
            if(!_productPrices.ContainsKey(request.ProductId))
            {
                return Task.FromResult($"Product with ID {request.ProductId} not found.");
            }

            _productPrices[request.ProductId] = request.NewPrice;
            return Task.FromResult($"Product {request.ProductId} price updated to {request.NewPrice:C}.");
        }
    }
}