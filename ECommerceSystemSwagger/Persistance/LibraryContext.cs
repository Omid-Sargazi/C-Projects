using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceSystemSwagger.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceSystemSwagger.Persistance
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options): base(options){}

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderItem> OrderItems{ get; set; }
        public DbSet<Manager> Managers{ get; set; }
        public DbSet<Review> Reviews{ get; set; }
        public DbSet<Payment> Payments{ get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}