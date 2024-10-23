using System;

class Program
{
    static void Main(string[] args)
    {
        String1();
        String2();
        String3();
        String4();
        Program program = new Program();
        program.String6();
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

    private void String6()
    {
        string message = "Welcome to C# programming!";
        if(message.Contains("C#"))
        {
            Console.WriteLine("The String contains C#");
        }else{
            Console.WriteLine("The string does not contain 'C#'");
        }
    } 
}