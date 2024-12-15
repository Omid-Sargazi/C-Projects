using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyModel;

namespace LibraryManagementSystem.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryManagementDbContext _context;
        private  IGenericRepository<Book> _books;
        private  IGenericRepository<Author> _authors;
        private  IGenericRepository<Category> _categories;
        private  IGenericRepository<LibraryMember> _libraryMembers;
        private  IGenericRepository<BookCategory> _booksCategory;

        public UnitOfWork(LibraryManagementDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Author> Authors => _authors ??= new GenericRepository<Author>(_context);

        public IGenericRepository<Category> Categories => _categories ??= new GenericRepository<Category>(_context);

        public IGenericRepository<Book> Books => _books ??=  new GenericRepository<Book>(_context);

        public IGenericRepository<LibraryMember> LibraryMembers => _libraryMembers ??= new GenericRepository<LibraryMember>(_context);

        public IGenericRepository<BookCategory> BookCategories => _booksCategory ??= new GenericRepository<BookCategory>(_context);

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}