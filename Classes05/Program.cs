using System;

namespace Classes{
    public static class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int num = 4;
            bool isEven = num.IsEven();
            Console.WriteLine($"{num} is even: {isEven}");
        }
    }
}