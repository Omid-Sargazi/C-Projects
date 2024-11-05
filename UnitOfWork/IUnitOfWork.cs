using System;

namespace UnitOfWOrk
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products{get;}
        IOrderRepository Order {get;}
        ICustomerRepository Customer {get;}
        int Complete();
    }


}