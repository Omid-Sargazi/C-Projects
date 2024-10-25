using System;

namespace Excercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var product = new Product {Name="Laptop", Price=99.99M};

            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            var products = new ProductEelctronic{ Name="TV", Price=89.36M};
            Console.WriteLine($"Product: {products.Name} Price: {products.Price}");
            Console.ResetColor();
            var numbers = new List<int> {1,2,3,4,5,6,7,};
            var sum = numbers.Sum();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sum: {sum}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************");
            Console.ResetColor();

            var Person = new
                        {
                     Name = "John Doe",
                    Age = 30,
                    Address = new { Street = "123 Maple St", City = "Anytown" }
                        };

            Console.WriteLine($"Name: {Person.Name}, Age: {Person.Age}, Street: {Person.Address.Street}, City: {Person.Address.City} ");
        }
    }


    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductEelctronic
    {
        public string Name { get; set;}
        public decimal Price { get; set; }
    }
}