using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem02.Core.Interfaces
{
    public interface IBookRepository
    {
        Task<int> AddBookAsync(Book book);
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(int id);
    }
}