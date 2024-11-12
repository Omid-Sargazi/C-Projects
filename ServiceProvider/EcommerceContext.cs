using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
    public class EcommerceContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {
        }
    }
}