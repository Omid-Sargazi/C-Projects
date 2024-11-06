namespace UnitOfWorkComplete
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
        }

        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }

        public IProductRepository Products { get; private set; }

        public int Complete()
    {
        return _context.SaveChanges(); // Commit all changes as a single transaction
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    }
}