using System;

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
        }
    }

}