using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num1=0;
        string num = Console.ReadLine();
        num1 = Convert.ToInt32(num);
        num1++;
        Console.WriteLine("" + num1);
    }
}