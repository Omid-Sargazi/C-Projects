using System;

class Program
{
    static void Main(string[] args)
    {
        PrintMessage();
        int result = addTwoNumber(2,3);
        Console.WriteLine("Add to number is: "+result);
        Console.WriteLine("Square a number is: "+Square(10));

        int num=5;
        IncrementValue(num);
        Console.WriteLine("After method call: "+num);

        int number=5;
        IncrementRef(ref number);
        Console.WriteLine("After method call: "+number);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("****************************");
        Console.ResetColor();
        Console.WriteLine("Double multiply two number"+Multiply(3.5,2.5));
        Console.WriteLine("int multiply two number"+Multiply(2,3));

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("****************************");
        Console.ResetColor();

        int quotient, remainder;
        Divide(10,3, out quotient, out remainder);
        Console.WriteLine($"Quotient: +{quotient}, Reminder: {remainder}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("***********************");
        Console.ResetColor();

        var resultt = Divided(10,3);
        Console.WriteLine($"Quotient: {resultt.Item1}, Remainder: {resultt.Item2}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("****************************");
        Console.ResetColor();

        int sum = SumNumbers(1,2,3,4);
        Console.WriteLine("Sum is: "+sum);
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

    static void IncrementValue(int a)
    {
        a+=1;
    }

    static void IncrementRef(ref int a)
    {
        a+=1;
    }

    static int Multiply(int a, int b)
    {
        return a*b;
    }

    static double Multiply(double a, double b)
    {
        return a*b;
    }

    static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a/b;
        remainder = a%b;
    }

    static Tuple<int, int> Divided(int a, int b)
    {
        return Tuple.Create(a/b,a%b);
    }

    static int SumNumbers(params int[] numbers)
    {
        int sum=0;
        foreach(int number in numbers)
        {
            sum+=number;
        }
        return sum;
    }
}