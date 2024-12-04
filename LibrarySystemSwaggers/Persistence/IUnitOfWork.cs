using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemSwaggers.Models;

namespace LibrarySystemSwaggers.Persistence
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<Book> Books { get; }
        IRepository<Member> Members { get; }
        IRepository<BorrowRecord> BorrowRecords { get; }
        Task SaveChangesAsync();
    }
}