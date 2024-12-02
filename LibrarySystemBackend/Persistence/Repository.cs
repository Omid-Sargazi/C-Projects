using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystemBackend.Persistence
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity)=> await _dbSet.AddAsync(entity);

        public async Task DeletAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if(entity!=null) _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()=>await _dbSet.ToListAsync();

        public async Task<T> GetByIdAsync(int id)=>await _dbSet.FindAsync(id);

        public async Task UpdateAsync(T entity){
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            
            }
    }
}