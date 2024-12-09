using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IRepository<Book> _books;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IRepository<Book> Books => _books ??= new Repository<Book>(_context);

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}