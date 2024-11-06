namespace UnitOfWorkComplete
{
    public interface IOrderRepository
    {
        Order Get(int id);
        IEnumerable<Order> GetAll();
        void Add(Order order);
        void Update(Order order);
        void Remove(Order order);
    }
}