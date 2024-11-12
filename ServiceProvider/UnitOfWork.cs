using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly EcommerceContext _context;

        public IRepository<Customer> Customers { get; }

        public UnitOfWork(EcommerceContext context)
        {
            _context = context;
            Customers = new Repository<Customer>(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }

}