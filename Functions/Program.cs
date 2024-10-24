using System;

class Program
{
    static void Main(string[] args)
    {
        PrintMessage();
        int result = addTwoNumber(2,3);
        Console.WriteLine("Add to number is: "+result);
        Console.WriteLine("Square a number is: "+Square(10));
    }

    static void PrintMessage()
    {
        Console.WriteLine("Hello World");
    }


    static int addTwoNumber(int a, int b)
    {
        return a+b;
    }

    private static int Square(int a)
    {
        return a*a;
    }
}