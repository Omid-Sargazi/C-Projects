using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly EcommerceContext _context;
        public IRepository<Customer> Customers { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Order> Orders { get; private set; }
        public IRepository<OrderItem> OrderItems { get; private set; }

        public UnitOfWork(EcommerceContext context)
        {
            _context = context;
            Customers = new Repository<Customer>(_context);
            Products = new Repository<Product>(_context);
            Orders = new Repository<Order>(_context);
            OrderItems = new Repository<OrderItem>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}