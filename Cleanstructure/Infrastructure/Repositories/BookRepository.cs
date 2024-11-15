using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cleanstructure.Infrastructure.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Book> GetAllBooksAsync()
        {
            return await _context.Books.Include(b=>b.Author).ToListAsync();
        }


        public void Add(Book book)
        {
            _context.Books.Add(book);
        }
    }
}