using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Application.Contracts.Persistence;

namespace LeaveManagement.Infrastructure.Repositories
{
    public class GenericRepository<T>:IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)=>await _context.Set<T>().AddAsync(entity);
        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        public void Update(T entity)=> _context.Set<T>().Update(entity);
        public void Delete(T entity)=> _context.Set<T>().Remove(entity);

        public async Task<T> GetByIdAsync(int id)
        {
           return await _context.Set<T>().FindAsync(id);
        }
    }
}