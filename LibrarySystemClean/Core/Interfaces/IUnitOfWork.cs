using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Book> Books { get; }
        IRepository<Customer> Customers { get; } 
        IRepository<Librarian> Librarians { get; }
        Task<int> CompleteAsync();
    }
}