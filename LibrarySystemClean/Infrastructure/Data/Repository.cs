using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet=context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)=>await _dbSet.FindAsync(id);
        public async Task<IEnumerable<T>> GetAllAsync()=>await _dbSet.ToListAsync();
        public async Task AddAsync(T entity) =>await _dbSet.AddAsync(entity);
        public void Update(T entity)=>_dbSet.Update(entity);
        public void Delete(T entity) => _dbSet.Remove(entity);  

    }
}