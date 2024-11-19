using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;

namespace CleanArchitectures.Application.Services
{
    public class ProductService:IProductService
    {
        private readonly IGenericRepository<Product> _repository;

        public ProductService(IGenericRepository<Product> repository)
        {
            _repository=repository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _repository.GetAllAsync();

            return products.Select(p=>new ProductDto
            {
                Name=p.Name;
                Price=p.Price;
            })
        }

        public async Task AddProductAsync(ProductDto productDTo)
        {
            var product = new Product{
                Name = productDTo.Name,
                Price=productDTo.Price,
            }
            await _repository.AddAsync(product);
        }
    }
}