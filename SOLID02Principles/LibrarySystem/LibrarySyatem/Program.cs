using System;
namespace LibrarySystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

           Library library = new Library();
            library.AddBook(new Book { Title = "1984", Author = "George Orwell", ISBN = "1234567890" });
            library.ListBook();
        }
    }
}