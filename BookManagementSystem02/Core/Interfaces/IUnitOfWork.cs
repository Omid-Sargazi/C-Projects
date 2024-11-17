using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem02.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IBookRepository bookRepository { get; }
        Task<int> CompleteAsync();
    }
}