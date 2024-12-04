using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystemSwaggers.Models;

namespace LibrarySystemSwaggers.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRepository<Book> _books;
        private readonly IRepository<Member> _members;
        private readonly IRepository<BorrowRecord> _borrowsRecord;
        private readonly LibraryContext _context;

        public UnitOfWork(LibraryContext context)
        {
            _context= context;
            _books = new Repository<Book>(_context);
            _members = new Repository<Member>(_context);
            _borrowsRecord = new Repository<BorrowRecord>(_context);
        }
        public IRepository<Book> Books => _books;
        public IRepository<Member> Members => _members;
        public IRepository<BorrowRecord> BorrowRecords=>_borrowsRecord;

        

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}