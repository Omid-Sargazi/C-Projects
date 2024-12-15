using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LibraryManagementSystem.Infrastructure.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LibraryManagementDbContext>
    {
        public LibraryManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryManagementDbContext>();
            optionsBuilder.UseSqlite("Data Source=LibraryManagementSystem.db");

            return new LibraryManagementDbContext(optionsBuilder.Options);
        }
    }
}