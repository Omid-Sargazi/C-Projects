using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Persistence
{
    public class LibraryManagementDbContext:DbContext
    {
        public LibraryManagementDbContext(DbContextOptions<LibraryManagementDbContext> options): base(options){}

        public LibraryManagementDbContext(){}


        public DbSet<Book> Books{ get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<LibraryMember> LibraryMembers{ get; set; }
        public DbSet<BookCategory> BookCategories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookCategory>()
            .HasKey(bc=>new {bc.BookId,bc.CategoryId});

            modelBuilder.Entity<BookCategory>()
            .HasOne(bc=>bc.Book)
            .WithMany(b=>b.BookCategories)
            .HasForeignKey(bc=>bc.BookId);

            modelBuilder.Entity<BookCategory>()
            .HasOne(bc=>bc.Category)
            .WithMany(c=>c.BookCategories)
            .HasForeignKey(bc => bc.CategoryId);
        }
    }
}