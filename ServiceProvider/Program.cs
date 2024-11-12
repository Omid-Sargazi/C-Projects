using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace ServiceProvider
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello");
           var serviceProvider = new ServiceCollection()
                .AddDbContext<EcommerceContext>(options => options.UseInMemoryDatabase("EcommerceDb"))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .BuildServiceProvider();
            var unitOfWork = serviceProvider.GetService<IUnitOfWork>();

            var product1 = new Product { Name = "Laptop", Price = 1000 };
            var product2 = new Product { Name = "Phone", Price = 500 };
            unitOfWork.Products.Add(product1);
            unitOfWork.Products.Add(product2);

            var customer = new Customer { Name = "John Doe", Email = "john@example.com" };
            unitOfWork.Customers.Add(customer);

            // Add new order
            var order = new Order { OrderDate = DateTime.Now, Customer = customer };
            unitOfWork.Orders.Add(order);

            // Add order items (products) to the order
            unitOfWork.OrderItems.Add(new OrderItem { Product = product1, Quantity = 1 });
            unitOfWork.OrderItems.Add(new OrderItem { Product = product2, Quantity = 2 });

            // Save changes
            unitOfWork.Save();

            var customersWithOrders = unitOfWork.Customers.Find(c => c.CustomerId == customer.CustomerId).FirstOrDefault();

            if (customersWithOrders != null)
            {
                Console.WriteLine($"Customer: {customersWithOrders.Name}");
                foreach (var ord in customersWithOrders.Orders)
                {
                    Console.WriteLine($"Order Date: {ord.OrderDate}");
                    foreach (var item in ord.OrderItems)
                    {
                        Console.WriteLine($"- Product: {item.Product.Name}, Quantity: {item.Quantity}, Total Price: {item.TotalPrice}");
                    }
                }
            }
    }
}
}
