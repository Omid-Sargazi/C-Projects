using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Infrastructure.Persistence
{
    public class AppDbContext:DbContext
    {
        public DbSet<Leave> Leaves{ get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
    }
}