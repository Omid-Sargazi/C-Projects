using Microsoft.EntityFrameworkCore;
namespace Librray
{
    public class LibraryDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionString"); // Replace with your actual connection string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

        modelBuilder.Entity<BorrowRecord>()
            .HasOne(br => br.Book)
            .WithMany()
            .HasForeignKey(br => br.BookId);
    }
    }
}