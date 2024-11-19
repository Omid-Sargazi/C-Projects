using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleanArchitectures.Core.Interfaces
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expressions<Func<T,bool>> predicate);
        Task AddAsync(T entity);    
        void Update(T entity);
        void Remove(T entity);
    }
    
}