namespace UnitOfWorkComplete
{
    public interface IUnitOfWork:IDisposable
    {
        ICustomerRepository customers { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        int Complete();
    }
}