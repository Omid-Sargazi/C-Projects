namespace Librray
{
    public interface IAuthorRepository
    {
        Author Get(int id);
        IEnumerable<Author> GetAll();
        void Add(Author author);
        void Update(Author author);
        void Remove(Author author);
    }    
}