using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDExample02.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDExample02.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    }
}