namespace UnitOfWorkComplete
{
    public interface IProductRepository
    {
        Product Get(int id);
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}