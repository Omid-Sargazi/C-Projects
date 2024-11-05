using System;
namespace UnitOfWOrk
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context=context;
            Products = new ProductRepository(_context);
            Orders = new OrderRepository(_context);
            Customers = new CustomerRepository(_context);
        }

        public IProductRepository Products { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public ICustomerRepository Customers { get; private set; }
    }

    public int Complete()
    {
        return _context.SaveChanges();  // Commits all changes at once
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}