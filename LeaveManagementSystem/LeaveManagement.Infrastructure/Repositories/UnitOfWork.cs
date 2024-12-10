using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Application.Contracts.Persistence;
using LeaveManagement.Domain.Entities;
using LeaveManagement.Infrastructure.Persistence;

namespace LeaveManagement.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private GenericRepository<Leave> _leaveRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        
        public IGenericRepository<Leave> LeaveRepository => _leaveRepository ??= new GenericRepository<Leave>(_context);

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}