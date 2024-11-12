using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Customer> Customers { get; }
        IRepository<Product> Products { get; }
        IRepository<Order> Orders { get; }
        IRepository <OrderItem> OrderItems { get; }
        void Save();
    }
}