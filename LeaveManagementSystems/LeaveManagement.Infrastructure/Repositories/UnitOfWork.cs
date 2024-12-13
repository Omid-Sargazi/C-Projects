using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Domain.Entities;
using LeaveManagement.Infrastructure.Persistence;

namespace LeaveManagement.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            LeaveRepository = new GenericRepository<Leave>(_context);
            
        }
        public GenericRepository<Leave> LeaveRepository {get;}

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}