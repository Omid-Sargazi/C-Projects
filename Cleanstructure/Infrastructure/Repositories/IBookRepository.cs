using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cleanstructure.Infrastructure.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        void Add(Book book);
    } 
}