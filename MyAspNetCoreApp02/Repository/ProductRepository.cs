using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAspNetCoreApp02.Models;

namespace MyAspNetCoreApp02.Repository
{
    public class ProductRepository
    {
        private static readonly List<Product> Products = new();

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static Product? GetProductById(Guid id)
        {
            return Products.FirstOrDefault(p=>p.Id==id);
        }

        public static void UpdateStock(Guid id, int newStock)
        {
            var product = GetProductById(id);
            if(product!=null)
            {
                product.Stock = newStock;
            }
        }
    }
}