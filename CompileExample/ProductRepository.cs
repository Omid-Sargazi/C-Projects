using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompileExample
{
    public class ProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Apple", Price = 1.5m },
                new Product { Id = 2, Name = "Banana", Price = 0.5m },
                new Product { Id = 3, Name = "Laptop", Price = 999.99m },
                new Product { Id = 4, Name = "Book", Price = 15.99m }
            };
        }

        public IEnumerable<Product> Find(ISpecification<Product> specification)
        {
            return _products.Where(specification.Criteria.Compile());
        }
    }
}