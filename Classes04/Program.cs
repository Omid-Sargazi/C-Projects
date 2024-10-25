using System;
using System.Linq; // Required for LINQ methods
using System.Collections.Generic; // Required for List<T>
namespace Classess
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello...");
            var peopel = new List<String> { "Alice", "Bob", "Charlie", "David"};
            var result = from person in peopel
                            where person.Length>3
                            orderby person
                            select person.ToUpper();
            foreach(var person in result)
            {
                Console.WriteLine(person);
            }
            // Another examples
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ResetColor();
            var fruits = new List<string> {"apple", "banana", "orange","aaapple"};
            var resultt = from fruit in fruits
            where fruit.Length > 0
            orderby fruit descending
            select fruit.ToUpper();
            foreach(var fruit in resultt)
            {
                Console.WriteLine($"{fruit}");
            }
            // *************************************************
            var numbers = Enumerable.Range(0,10);
            var evenNumber = numbers.Where(n=>n%2==0);
            foreach(var number in evenNumber)
            {
                Console.WriteLine(number);
            }

            // *********************************************
            var names = new List<string> {"Charlie", "Alice", "Bob"};
            var sortedName = names.OrderBy(name=>name);
            foreach(var name in sortedName)
            {
                Console.WriteLine(name);
            }

            var numberss = Enumerable.Range(0,21);
            var resultss = numberss.Where(n=>n%2==0).Select(n=>n*n).OrderByDescending(n=>n);
            foreach(var num in resultss)
            {
                Console.Write(", "+num);
            }

           string original = "Hello";
            string reversed = original.Reverse(); // Call the extension method
            Console.WriteLine($"Original: {original}, Reversed: {reversed}");
            // *********************************************
            
        }
    }



}