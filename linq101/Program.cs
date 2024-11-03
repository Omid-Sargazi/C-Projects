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
            ////////////////////////////////////////
            List<string> words = new List<string>{"apple","banana","cherry"};
            var wordLength = words.Select(x=>x.Length).ToList();

            foreach(var x in wordLength)
            {
                Console.WriteLine($"Lengths are: {x}");
            }
            ///////////////////////////////////////////////
            ///OrderBy
            List<string> namess = new List<string>{"Charlie","Alice","Bob"};
            var sortedNames = namess.OrderBy(x=>x).ToList();
            foreach(var x in sortedNames)
            {
                Console.WriteLine($"{x}");
            }
//////////////*************************************************************
            List<int> num01 = new List<int>{3,2,4};
            var sortedNum01 = num01.OrderBy(x=>x).ToList();

            for(int i=0;i<sortedNum01.Count;i++)
            {
                Console.WriteLine(sortedNum01[i]);
            }

//////////////*************************************************************OredrByDescending

           List<string> Names = new List<string>{"Charlie", "Alice", "Bob"};
           var sortedNames02 = Names.OrderByDescending(x=>x);
           
           foreach(var name in sortedNames02)
           {
            Console.WriteLine($"OredrByDescending:  {name}");
           }

        List<int> num03 = new List<int>{3,2,4,5,6,-10};
        var sortedNum03 = num03.OrderByDescending(x=>x);
        

        }
    }
}