using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Domain.Entities;

namespace LibraryManagementSystem.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<Author> Authors {get;}
        IGenericRepository<Category> Categories {get;}
        IGenericRepository<Book> Books {get;}
        IGenericRepository<LibraryMember> LibraryMembers {get;}
        IGenericRepository<BookCategory> BookCategories {get;}

        Task<int> CompleteAsync();

    }
}