﻿using System;
namespace Repository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Helloo");
            var productRepo = new Repository<Product>();
            productRepo.Add(new Product { Id = 1, Name = "Laptop", Price = 1200 });
            productRepo.Add(new Product { Id = 2, Name = "Smartphone", Price = 800 });

            var allProducts = productRepo.GetAll();
            foreach (var product in allProducts)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            var expensiveProduct = productRepo.Find(p=>p.Price>1000);
            Console.WriteLine($"Expensive Product:{expensiveProduct?.Name},Price:{expensiveProduct?.Price}");
            productRepo.Update(1,new Product{Id=1,Name="Laptop Pro",Price=1500});
            var updatedProduct = productRepo.GetById(1);
            Console.WriteLine($"Updated Product:{updatedProduct.Name},Price:{updatedProduct.Price}");

            var logger = new Logger<string>();
            logger.Log("This is a log message.");

            var intLogger = new Logger<int>();
            intLogger.Log(42);

            var productValidator = new Validator<Products>();
            var products = new Products{Id=1,Name="Laptop",Price=1200};
            bool isValidPrice = productValidator.isValid(products,products=>products.Price>1000);
            Console.WriteLine($"Is the product price valid? {isValidPrice}");

            //////////////////////////////////////////////////////////
            var customerValidator = new Validator<Customer>();
            var customer = new Customer {Id=1,FullName = "John Doe", Email = "john@example.com"};
            bool isValidEmail = customerValidator.isValid(customer,c=>c.Email.Contains("@"));
            Console.WriteLine($"Is the customer email valid? {isValidEmail}");



        }
    }
}