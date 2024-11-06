namespace UnitOfWorkComplete
{
    public class OrderRepository:IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public Order Get(int id)=>_context.Orders.Find(id);
        public IEnumerable<Order> GetAll()=>_context.Orders.ToList();
        public void Add(Order order)=>_context.Orders.Add(order);
        public void Update(Order order)=>_context.Orders.Update(order);
        public void Remove(Order order)=>_context.Orders.Remove(order);

    }
}