using System;

class Program
{
    static void Main(string[] args)
    {
        String1();
        String2();
        String3();
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

    private static void String3()
    {
        string message = "HEllO, wORlD";
        Console.WriteLine("Lowercase"+ message.ToLower());
        Console.WriteLine("UpperCase"+ message.ToUpper());
    }

    private static void String4()
    {
        string message = "omid Sargazi is a .net expertise";
        string subString = message.Substring(2,4);
        Console.WriteLine(""+ subString);
    }
}