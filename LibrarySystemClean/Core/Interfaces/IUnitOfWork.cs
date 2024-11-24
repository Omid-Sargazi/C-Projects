using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Book> Books { get; }
        IRepository<Customer> Customers { get; } 
        IRepository<Librarian> Librarian { get; }
        Task<int> SaveChangesAsync();
    }
}