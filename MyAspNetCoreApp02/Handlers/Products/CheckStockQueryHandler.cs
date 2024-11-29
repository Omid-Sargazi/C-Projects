using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp02.Repository;
using MyAspNetCoreApp02.Requests.Products;

namespace MyAspNetCoreApp02.Handlers.Products
{
    public class CheckStockQueryHandler:IRequestHandler<CheckStockQuery,int>
    {
        public Task<int> Handle(CheckStockQuery request, CancellationToken cancellationToken)
        {
            var product = ProductRepository.GetProductById(request.ProductId);
            if(product == null)
            {
                throw new KeyNotFoundException($"Product with ID {request.ProductId} not found.");
            }

            return Task.FromResult(product.Stock);
        }
    }
}