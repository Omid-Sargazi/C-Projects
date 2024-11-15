using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cleanstructure.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IBookRepository BookRepository { get; }
        Task CommitAsync();
    }

    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IBookRepository BookRepository { get; }

        public UnitOfWork(AppDbContext context, IBookRepository bookRepository)
        {
            _context = context;
            BookRepository = bookRepository;
        }

        public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
    }
}