using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemBackend.Models;

namespace LibrarySystemBackend.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Book> books {get;}
        Task SaveChangesAsync();
       
    }
}