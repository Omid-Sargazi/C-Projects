using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EcommerceContext _context;

        public Repository(EcommerceContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
    }
}