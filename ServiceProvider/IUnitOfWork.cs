using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
    public interface IUnitOfWork
    {
        IRepository<Customer> Customers { get; }
        void Save();
    }
}