using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddDbContext<LibraryContext>(options => options.UseInMemoryDatabase("LibraryDb"))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .BuildServiceProvider();

            // Get UnitOfWork instance
            var unitOfWork = serviceProvider.GetService<IUnitOfWork>();

            // Add Authors
            var author1 = new Author { Name = "J.K. Rowling" };
            var author2 = new Author { Name = "George Orwell" };
            unitOfWork.Authors.Add(author1);
            unitOfWork.Authors.Add(author2);

            // Add Books
            var book1 = new Book { Title = "Harry Potter and the Philosopher's Stone", ISBN = "1234567890", Price = 19.99m, Author = author1 };
            var book2 = new Book { Title = "1984", ISBN = "0987654321", Price = 9.99m, Author = author2 };
            unitOfWork.Books.Add(book1);
            unitOfWork.Books.Add(book2);

            // Add Members
            var member1 = new Member { FullName = "John Doe", Email = "john.doe@example.com" };
            unitOfWork.Members.Add(member1);

            // Add Rental
            var rental = new Rental { Book = book1, Member = member1, RentalDate = DateTime.Now };
            unitOfWork.Rentals.Add(rental);

            // Save changes
            unitOfWork.Save();

            // LINQ: Get all rented books
            var rentedBooks = unitOfWork.Rentals.GetAll().Where(r => r.ReturnDate == null).ToList();
            Console.WriteLine("Rented Books:");
            foreach (var rentalRecord in rentedBooks)
            {
                Console.WriteLine($"Book: {rentalRecord.Book.Title}, Rented by: {rentalRecord.Member.FullName}, Rental Date: {rentalRecord.RentalDate}");
            }

            // LINQ: Find authors with more than 1 book
            var authorsWithMultipleBooks = unitOfWork.Authors.Find(a => a.Books.Count > 1);
            Console.WriteLine("\nAuthors with Multiple Books:");
            foreach (var author in authorsWithMultipleBooks)
            {
                Console.WriteLine($"Author: {author.Name}");
            }
        }
    }
}
