using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly LibraryContext _context;
        public IRepository<Book> Books { get; private set; }
        public IRepository<Author> Authors { get; private set; }
        public IRepository<Member> Members { get; private set; }
        public IRepository<Rental> Rentals { get; private set; }

         public UnitOfWork(LibraryContext context)
        {
            _context = context;
            Books = new Repository<Book>(_context);
            Authors = new Repository<Author>(_context);
            Members = new Repository<Member>(_context);
            Rentals = new Repository<Rental>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}