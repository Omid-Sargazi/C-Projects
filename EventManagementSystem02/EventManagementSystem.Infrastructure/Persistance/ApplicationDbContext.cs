using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.Infrastructure.Persistance
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options){}
        public DbSet<Event> Events{ get; set; }
        public DbSet<Venue> Venues{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>()
            .HasOne(e=>e.Venue)
            .WithMany(e=>e.Events)
            .HasForeignKey(e=>e.VenueId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}