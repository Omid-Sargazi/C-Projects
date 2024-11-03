using System;

namespace Linq101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            List<int> numbers = new List<int>{1,2,3,10,200,-200,20,37};
            var evenNumber = numbers.Where(x=>x%2==0).ToList();
            foreach(var x in evenNumber)
            {
                Console.WriteLine(x);
            }

            for(int i=0;i<evenNumber.Count;i++)
            {
                Console.WriteLine(evenNumber[i]);
            }
            /////////////////////////////////////////
            List<string> names = new List<string>{"Anna","Bob","Cahrlie","David"};
            var shortNames = names.Where(x=>x.Length<=3).ToList();

            foreach(var x in shortNames)
            {
                Console.WriteLine($"length less then 3 are: {x}");
            }


        }
    }
}