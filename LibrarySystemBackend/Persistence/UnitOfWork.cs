using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemBackend.Models;

namespace LibrarySystemBackend.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;
        private IRepository<Book> _books;

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }
        public IRepository<Book> books => _books ??=new Repository<Book>(_context);
        public void Dispose()=> _context.Dispose();

        public async Task SaveChangesAsync()=>await _context.SaveChangesAsync();
    }
}