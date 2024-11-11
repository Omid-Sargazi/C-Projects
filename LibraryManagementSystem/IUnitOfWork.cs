using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Book> Books { get; }
        IRepository<Author> Authors { get; }
        IRepository<Member> Members { get; }
        IRepository<Rental> Rentals { get; }
        void Save();
    }
}