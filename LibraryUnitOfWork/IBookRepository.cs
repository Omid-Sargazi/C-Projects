namespace Librray
{
    public interface IBookRepository
    {
        Book Get(int id);
        IEnumerable<Biik> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Remove(Book book);
    }
}