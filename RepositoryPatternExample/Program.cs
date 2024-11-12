using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace RepositoryPatternExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            var serviceProvider = new ServiceCollection()
                .AddDbContext<EcommerceContext>(options => options.UseInMemoryDatabase("EcommerceDb"))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .BuildServiceProvider();

                var unitOfWork = serviceProvider.GetService<IUnitOfWork>();

                var product1 = new Product {Name = "Laptop", Price = 1000};
                var product2 = new Product {Name = "Phone", Price = 500};


                unitOfWork.Products.Add(product1);
                unitOfWork.Products.Add(product2);

                var customer = new Customer { Name = "John Doe", Email = "john@example.com" };

                unitOfWork.Customers.Add(customer);

                var order = new Order
            {
                OrderDate = DateTime.Now,
                Customer = customer
            };

            unitOfWork.Orders.Add(order);

            unitOfWork.OrderItems.Add(new OrderItem { Order = order, Product = product1, Quantity = 1 });
            unitOfWork.OrderItems.Add(new OrderItem { Order = order, Product = product2, Quantity = 2 });

            // Save changes to the database
            await unitOfWork.SaveAsync();

            var customerWithOrders = unitOfWork.Customers
                .Find(c => c.CustomerId == customer.CustomerId)
                .FirstOrDefault();

            if (customerWithOrders != null)
            {
                Console.WriteLine($"Customer: {customerWithOrders.Name}");
                foreach (var ord in customerWithOrders.Orders)
                {
                    Console.WriteLine($"Order Date: {ord.OrderDate}");
                    var orderItems = ord.OrderItems;
                    foreach (var item in orderItems)
                    {
                        Console.WriteLine($"- Product: {item.Product.Name}, Quantity: {item.Quantity}, Price: {item.Product.Price}");
                    }
                }
            }
        }
    }
}