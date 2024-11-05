namespace UnitOfWOrk02
{
    public class OrderRepository
    {
        private readonly AppDbContext _context;
         public OrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public Order Find(int orderId)
    {
        return _context.Orders.Find(orderId);
    }

    public void Update(Order order)
    {
        _context.Orders.Update(order);
        _context.SaveChanges();
    }

    public void Remove(Order order)
    {
        _context.Orders.Remove(order);
        _context.SaveChanges();
    }
    }
}