namespace UnitOfWOrk02
{
    public class CustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customer Find(int customerId)
    {
        return _context.Customers.Find(customerId);
    }

    public void Update(Customer customer)
    {
        _context.Customers.Update(customer);
        _context.SaveChanges();
    }
    }
}