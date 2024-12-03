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
        private IRepository<Member> _members;
        private IRepository<BorrowRecord> _borrowRecords;

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }
        public IRepository<Book> books => _books ??=new Repository<Book>(_context);

        public IRepository<Member> members => _members ??= new Repository<Member>(_context);
        public IRepository<BorrowRecord> borrows => _borrowRecords ??= new Repository<BorrowRecord>(_context);
        public void Dispose()=> _context.Dispose();

        public async Task SaveChangesAsync()=>await _context.SaveChangesAsync();
    }
}