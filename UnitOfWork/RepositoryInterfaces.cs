using System;
namespace UnitOfWOrk
{
    public interface IProductRepository
    {
        void UpdateStock(int productId, int quantity);
    }

    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }

    public interface ICustomerRepository
    {
        void DeductBalance(int customerId, decimal amount);
    }
}