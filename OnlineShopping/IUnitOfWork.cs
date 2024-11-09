using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSystem
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Customer> Customers { get; }
        IRepository<Product> Products { get; }
        IRepository<Order> orders { get; }
        IRepository<OrderItem> OrderItems { get; }
        Task<int> SaveAsync();

    }
}