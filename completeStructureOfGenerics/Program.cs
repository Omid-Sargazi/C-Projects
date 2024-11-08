using System;

namespace CompleteStrcture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1500 },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 20 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 40 }
        };

        var productRepo = new Repository<Product>(products);
        var expensiveProduct = productRepo.Find(p=>p.Price>1000);
        Console.WriteLine($"Expensive Product: {expensiveProduct?.Name}, Price: {expensiveProduct?.Price}");

        }
    }
}