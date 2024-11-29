using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp02.Repository;
using MyAspNetCoreApp02.Requests.Products;

namespace MyAspNetCoreApp02.Handlers.Products
{
    public class ReduceStockCommandHandler:IRequestHandler<ReduceStockCommand,string>
    {
        public Task<string> Handle(ReduceStockCommand request,CancellationToken cancellationToken)
        {
            var product = ProductRepository.GetProductById(request.ProductId);

            if(product == null)
            {
                throw new KeyNotFoundException($"Product with ID {request.ProductId} not found.");
            }
            if(product.Stock<request.Quantity)
            {
                    throw new InvalidOperationException($"Insufficient stock for product '{product.Name}'. Current stock: {product.Stock}");
            }

            product.Stock-=request.Quantity;
            ProductRepository.UpdateStock(request.ProductId,product.Stock);
            return Task.FromResult($"Reduced {request.Quantity} units from product '{product.Name}'. Remaining stock: {product.Stock}");
        }


    }
}
