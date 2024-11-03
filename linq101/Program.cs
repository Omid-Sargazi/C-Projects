using System;

namespace Linq101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            List<int> numbers = new List<int>{1,2,3,10,200,-200,20,37};
            var evenNumber = numbers.Where(x=>x%2==0);
            foreach(var x in evenNumber)
            {
                Console.WriteLine(x);
            }
            

        }
    }
}