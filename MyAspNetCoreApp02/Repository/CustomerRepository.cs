using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAspNetCoreApp02.Models;

namespace MyAspNetCoreApp02.Repository
{
    public class CustomerRepository
    {
        private static readonly List<Customer> Customers=new();

    public static void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public static Customer? GetCustomerById(Guid id)
    {
        return Customers.FirstOrDefault(c=>c.Id==id);
    }
    }
}