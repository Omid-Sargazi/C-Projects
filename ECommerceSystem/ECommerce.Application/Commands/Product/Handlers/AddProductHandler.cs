using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Application.Commands.Product.Handlers
{
    public class AddProductHandler:IRequestHandler<AddProductRequest,Guid>
    {
        private readonly IGenericRepository<Product> _repository;

        public AddProductHandler(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(AddProductRequest request,CancellationToken cancellationToken)
        
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name=request.Name,
                Description=request.Description,
                Price=request.Price,
                CategoryId=request.CategoryId,
            };
            await _repository.AddAsync(product);
            return product.Id;
        }
    }
}