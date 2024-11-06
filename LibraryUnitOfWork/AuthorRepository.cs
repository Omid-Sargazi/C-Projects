namespace Librray
{
    public class AuthorRepository:IAuthorRepository
    {
        private readonly LibraryDbContext _context;
        public AuthorRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public Author Get(int id)=>_context.Authors.Find(id);
        public IEnumerable<Author> GetAll() => _context.Authors.ToList();

        public void Add(Author author) => _context.Authors.Add(author);

        public void Update(Author author) => _context.Authors.Update(author);

        public void Remove(Author author) => _context.Authors.Remove(author);

    }
}