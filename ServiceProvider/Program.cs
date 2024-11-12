using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace ServiceProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<EcommerceContext>(options => options.UseInMemoryDatabase("EcommerceDb"))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .BuildServiceProvider();

            // Step 5: Use the service provider to get the instance of IUnitOfWork
            var unitOfWork = serviceProvider.GetService<IUnitOfWork>();

            // Step 6: Perform some operations (e.g., add a customer)
            var customer = new Customer { Name = "John Doe", Email = "john.doe@example.com" };
            unitOfWork.Customers.Add(customer);

            // Step 7: Save changes to the database
            unitOfWork.Save();

            // Step 8: Retrieve and display the customer to show it was added
            // var addedCustomer = unitOfWork.Customers as Repository<Customer>;
            // var customerList = addedCustomer.GetType().GetMethod("Add")?.Invoke(addedCustomer, null); // using reflection just for demonstration
            var addedCustomer = unitOfWork.Customers as Repository<Customer>;

// Add the customer without using reflection
        addedCustomer?.Add(customer);

// Display a success message
        Console.WriteLine("Customer added successfully!");
        Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");

            Console.WriteLine("Customer added successfully!");

            // Display the customer details
            Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");
            
        }
    }
}
 
