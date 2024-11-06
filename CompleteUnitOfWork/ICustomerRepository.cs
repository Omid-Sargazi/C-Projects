namespace UnitOfWorkComplete
{
    public class ICustomerRepository
    {
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
        void Add(Customer customer);
        void Upadte(Customer customer);
        void Remove(Customer customer);