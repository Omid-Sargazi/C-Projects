namespace UnitOfWorkComplete
{
    public interface ICustomerRepository
    {
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
        void Add(Customer customer);
        void Upadte(Customer customer);
        void Remove(Customer customer);
    }

}