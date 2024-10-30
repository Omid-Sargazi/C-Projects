using System;
namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Book book1 = new Book();
            book1.Title = "C# Programming";
            book1.Author = "John Doh";
            book1.DidplayInfo();
        }
    }
}