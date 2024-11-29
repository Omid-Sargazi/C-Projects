using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAspNetCoreApp02.Models;

namespace MyAspNetCoreApp02.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<NewProduct> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    }
}