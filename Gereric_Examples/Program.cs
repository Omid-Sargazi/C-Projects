using System;

namespace Generic_Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, StockQuantity = 10, CreatedDate = DateTime.Now.AddMonths(-2) },
                new Product { Id = 2, Name = "Smartphone", Category = "Electronics", Price = 800, StockQuantity = 15, CreatedDate = DateTime.Now.AddMonths(-1) },
                new Product { Id = 3, Name = "Desk", Category = "Furniture", Price = 300, StockQuantity = 5, CreatedDate = DateTime.Now.AddMonths(-6) },
                new Product { Id = 4, Name = "Chair", Category = "Furniture", Price = 120, StockQuantity = 20, CreatedDate = DateTime.Now.AddMonths(-3) },
                new Product { Id = 5, Name = "Tablet", Category = "Electronics", Price = 600, StockQuantity = 12, CreatedDate = DateTime.Now.AddMonths(-5) },
                new Product { Id = 6, Name = "Monitor", Category = "Electronics", Price = 400, StockQuantity = 8, CreatedDate = DateTime.Now.AddMonths(-4) },
                new Product { Id = 7, Name = "Keyboard", Category = "Accessories", Price = 50, StockQuantity = 50, CreatedDate = DateTime.Now.AddMonths(-1) },
                new Product { Id = 8, Name = "Mouse", Category = "Accessories", Price = 30, StockQuantity = 100, CreatedDate = DateTime.Now.AddMonths(-2) }
            };


            var expensiveProducts = products.Where(p=>p.Price>500).ToList();
            var sortedByPrice = products.OrderBy(p=>p.Price).ToList();
            var sortedByPriceDesc = products.OrderByDescending(p=>p.Price).ToList();
            var productDetails = products.Select(p=>new {p.Name,p.Price}).ToList();
            var electronics = products.Where(p=>p.Category=="Electronics").ToList();
            var mostExpensiveProduct = products.OrderBy(p=>p.Price).FirstOrDefault();
            var mostCheapProduct = products.OrderByDescending(p=>p.Price).FirstOrDefault();
            var averagePrice = products.Average(p=>p.Price);
            var groupedByCategory = products.GroupBy(p=>p.Category).ToList();
            var recentProducts = products.Where(p=>p.CreatedDate>=DateTime.Now.AddMonths(-3));

            Console.WriteLine($"Cheapest: {mostCheapProduct.Price}, most expensive: {mostExpensiveProduct.Price}");

            foreach (var item in recentProducts)
            {
                // Console.WriteLine($"ID: {item.Id},Name:{item.Name},Category: {item.Category}, Price: {item.Price},Stock:{item.StockQuantity}");
                Console.WriteLine($"Name: {item.Name} Price:{item.Price}");
            }

            
        }
    }
}