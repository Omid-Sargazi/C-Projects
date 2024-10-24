using System;

class Program
{
    static void Main(string[] args)
    {
        // String1();
        // String2();
        // String3();
        // String4();
        // Program program = new Program();
        // program.String6();
        // Console.ForegroundColor = ConsoleColor.Red;
        // Console.WriteLine("********************");
        // Console.ResetColor();
        // program.String7();
        // String8();
        // String9();
        // Variables();
        // ifSentence();
        OddEven();
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

    private void String7()
    {
        string message ="Hello World";
        string newMassage = message.Replace("World", "omid");
        Console.WriteLine("Updated message  : "+ newMassage);
    }
    private static void String8()
    {
        string sentence = "C# is a powerful programming language";
        string[] words = sentence.Split(" ");
        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
    }

    private static void String9()
    {
        string message = "CSharp";
        char[] charArray = message.ToCharArray();
        Array.Reverse(charArray);
        string reverseString = new string(charArray);
        Console.WriteLine(""+ reverseString);
    }

    private static void Variables()
    {
        int age=42;
        double height=169;
        bool isLearning = true;
        string name="omid";
        Console.WriteLine($"Name:{name},Age:{age}, height: {height}, Learning: {isLearning}, name: {name}");
    }


    private static void ifSentence()
    {
        int number=10;
        if(number>5)
        {
            Console.WriteLine("Number is greater than 5");
        }else
        {
            Console.WriteLine("Number is 5 or less than 5");
        }

        for(int i=0;i<5;i++)
        {
            Console.WriteLine($"Iteration {i}");
        }
    }

    private static void OddEven()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        if(number%2==0)
        {
            Console.WriteLine($"{number} is an even number.");
        }else{
            Console.WriteLine($"{number} is an odd number");
        }
    }

}