namespace UnitOfWorkComplete
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context=context;
        }

        public Customer Get(int id) =>_context.Customers.Find(id);
        public IEnumerable<Customer> GetAll()=>_context.Customers.ToList();
        public void Add(Customer customer) =>_context.Customers.Add();
        public void Upadte(Customer customer)=>_context.Customers.Upadte(customer);
        public void Remove(Customer customer)=>_context.Customers.Remove(customer);

    }
}