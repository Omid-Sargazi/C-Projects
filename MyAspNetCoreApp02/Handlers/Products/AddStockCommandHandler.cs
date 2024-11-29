using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyAspNetCoreApp02.Repository;
using MyAspNetCoreApp02.Requests.Products;

namespace MyAspNetCoreApp02.Handlers.Products
{
    public class AddStockCommandHandler:IRequestHandler<AddStockCommand,string>
    {
        public Task<string> Handle(AddStockCommand request,CancellationToken cancellationToken)
        {
            var product = ProductRepository.GetProductById(request.ProductId);

            if(product==null)
            {
                throw new KeyNotFoundException($"Product with ID {request.ProductId} not found.");
            }
            product.Stock+=request.Quantity;
            ProductRepository.UpdateStock(request.ProductId,product.Stock);
            return Task.FromResult($"Added {request.Quantity} units to product '{product.Name}'. New stock: {product.Stock}");
        }
    }
}