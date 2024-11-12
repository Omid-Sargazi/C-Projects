using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace LibraryManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var serviceProvider = new ServiceCollection()
                .AddDbContext<LibraryContext>(options => options.UseInMemoryDatabase("LibraryDb"))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .BuildServiceProvider();

            var unitOfWork = serviceProvider.GetService<IUnitOfWork>();

            // Add authors
            var author1 = new Author { Name = "J.K. Rowling" };
            var author2 = new Author { Name = "George Orwell" };
            unitOfWork.Authors.Add(author1);
            unitOfWork.Authors.Add(author2);

            // Add books
            var book1 = new Book { Title = "Harry Potter", ISBN = "123", Price = 20, Author = author1 };
            var book2 = new Book { Title = "1984", ISBN = "456", Price = 15, Author = author2 };
            unitOfWork.Books.Add(book1);
            unitOfWork.Books.Add(book2);

            // Add a member
            var member = new Member { FullName = "John Doe", Email = "john@example.com" };
            unitOfWork.Members.Add(member);

            // Rent a book
            var rental = book1.Rent(member);
            unitOfWork.Rentals.Add(rental);
            unitOfWork.Save();

            // LINQ: Query rented books
            var rentedBooks = unitOfWork.Rentals.GetAll()
                .Where(r => r.ReturnDate == null)
                .ToList();
            Console.WriteLine("Rented Books:");
            foreach (var rentalRecord in rentedBooks)
            {
                Console.WriteLine($"Book: {rentalRecord.Book.Title}, Rented by: {rentalRecord.Member.FullName}, Date: {rentalRecord.RentalDate}");
            }

            // LINQ: Authors with more than 1 book
            var authorsWithMultipleBooks = unitOfWork.Authors.Find(a => a.Books.Count > 1);
            Console.WriteLine("\nAuthors with Multiple Books:");
            foreach (var author in authorsWithMultipleBooks)
            {
                Console.WriteLine($"Author: {author.Name}");
            }
            
        }
    }
}