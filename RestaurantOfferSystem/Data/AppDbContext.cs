using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantOfferSystem.Models;

namespace RestaurantOfferSystem.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Restaurant> Restaurants{ get; set; }
        public DbSet<Offer> Offers{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=restaurantoffers.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
            .HasMany(r=>r.Offers)
            .WithOne(o=>o.Restaurant)
            .HasForeignKey(o=>o.Restaurant.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}