using System;

namespace Excercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var product = new Product {Name="Laptop", Price=99.99M};

            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
        }
    }


    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}