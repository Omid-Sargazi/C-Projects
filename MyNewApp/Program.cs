using System;

class Program
{
    static void Main(string[] args)
    {
        String1();
        String2();
    }


    private static void String1()
    {
        string fname="omid";
        string lname="Sa";
        string fullName = fname+" "+lname;
        Console.WriteLine("" + fullName);

    }

    private static void String2()
    {
        string message = "Hello, World";
        Console.WriteLine("Lengths  of the string is: "+message.Length);
    }
}