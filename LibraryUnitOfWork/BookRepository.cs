namespace Librray
{
    public class BookRepository:IBookRepository
    {
        private readonly LibraryDbContext _context;
        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public Book Get(int id) => _context.Books.Find();
        public IEnumerable<Book> GetAll()=>_context.Books.ToList();
        public void Add(Book book)=>_context.Books.Add(book);
        public void Update(Book book)=>_context.Books.Update(book);
        public void Remove(Book book) => _context.Books.Remove(book);
    }


}