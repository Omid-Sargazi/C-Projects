using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem.Infrastructure.Data
{
    public class BookRepository:IBookRepository
    {
        private readonly List<Book> books = new List<Book>();

        public async Task<int> AddBookAsync(Book book)
        {
            book.Id = _books.Count + 1;
            _books.Add(book);
            return await Task.FromResult(book.Id);
        }
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await Task.FromResult(_books);
        }

    }
}