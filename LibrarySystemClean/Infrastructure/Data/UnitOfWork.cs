using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Entities;


namespace Infrastructure.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }


        public IRepository<Book> Books =>new Repository<Book>(_context);
        public IRepository<Customer> Customers =>new Repository<Customer>(_context);
       public IRepository<Librarian> Librarians => new Repository<Librarian>(_context);

        public async Task<int> CompleteAsync()=>await _context.SaveChangesAsync();

        
    }
}