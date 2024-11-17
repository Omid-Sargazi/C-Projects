using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem.Core.Interfaces
{
    public interface IBookRepository
    {
        Task<int> AddBookAsync(Book book);
        Task<List<Book>> GetAllBookAsync();
    }
}