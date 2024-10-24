using System;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

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
        // OddEven();
        // SimpleCalculator();
        // CheckLeapYear();
        // MaximumThreeNumbers();
        // CountNumberDigits();
        // Factorial();
        // SumOfDigits();
        // Fibonacci();
        // ReverseString();
        // StringToChar();
        Palindrome();
        PrimeNumber();
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

    private static void SimpleCalculator()
    {
        Console.WriteLine("Enter two numbe: ");
        double num1 = double.Parse(Console.ReadLine());

        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operation (+,-,/,*): ");

        char operation = Console.ReadLine()[0];

        double result=0;

        switch(operation)
        {
            case '+':
            result = num1+num2;
            break;

            case '-':
            result = num1-num2;
            break;

            case '*':
            result = num1 * num2;
            break;

            case '/':
            result = num1/num2;
            break;

            default:
            Console.WriteLine("Invalid Operation");
            break;
        }

        Console.WriteLine($"Result is {result}");
    }

    private static void CheckLeapYear()
    {
        Console.WriteLine("Enter a year.");
        int year = int.Parse(Console.ReadLine());
        if((year %4 ==0 && year %100 !=0)||(year%400==0))
        {
            Console.WriteLine($"{year} is leap year.");
        }else{
            Console.WriteLine($"{year} is not a leap year");
        }
    }


    private static void MaximumThreeNumbers()
    {
        Console.WriteLine("Enter three Number: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double max = num1;

        if(num2>num1)
        {
            max=num2;
        }if(num3>num2)
        {
            max=num3;
        }

        Console.WriteLine($"Max is {max}");

    }

    private static void CountNumberDigits()
    {
        Console.WriteLine("Enter an Integer:");

        int number = int.Parse(Console.ReadLine());
        int count=0;
        while(number !=0)
        {
            number /=10;
            count++;
        }
        Console.WriteLine($"The number of digits is {count}");

    } 

    private static void Factorial()
    {
        Console.WriteLine("Enter a number");
        int num = int.Parse(Console.ReadLine());
        int factorial=1;

        for(int i=1;i<=num;i++)
        {
            factorial*=i;
        }
        Console.WriteLine($"Factorial of {num} is {factorial}");
    }

    private static void SumOfDigits()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        int sum=0;

        while(number!=0)
        {
            sum+=number%10;
            number/=10;
        }
        Console.WriteLine($"The sum of digits is {sum}");
    }

    private static void Fibonacci()
    {
        Console.WriteLine("Enter the number of terms: ");
        int terms =int.Parse(Console.ReadLine());
        int num1=0;
        int num2=1;
        int result;
            Console.WriteLine("Fibonacci Series:");
        for(int i=1;i<=terms;i++)
        {   
            Console.WriteLine(num1);
            result = num1+num2;
            num1=num2;
            num2=result;

        }
    }

    private static void ReverseString()
    {
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        char[] cahrArray = input.ToCharArray();
        Array.Reverse(cahrArray);
        string reversed = new string(cahrArray);
        Console.WriteLine($"Reversed string {reversed}");
    }

    private static void StringToChar()
    {
        Console.WriteLine("Enter a String:");
        string name= Console.ReadLine();
        
        foreach(char c in name)
        {
            Console.WriteLine($" chars are {c}");
        }
    }

    private static void Palindrome()
    {
        Console.WriteLine("Enter a string...");
        string input = Console.ReadLine();
        string reversed = new string(input.ToCharArray().Reverse().ToArray());

        if(input==reversed)
        {
            Console.WriteLine($"{input} is a Palindrome");
        }
        else{
            Console.WriteLine($"{input} is not a Palindrome");
        }
    }

    private static void PrimeNumber()
    {
        Console.WriteLine("Enetr a number fro checking is a prime or not");
        int number = int.Parse(Console.ReadLine());
        bool isPrime=true;
            if(number<2)
            {
                isPrime=false;
            }else
            {

        for(int i=2;i<=Math.Sqrt(number);i++)
        {
            if(number%i==0)
            {
                isPrime=false;
                break;
            }
        }
            }

            if(isPrime)
            {
                Console.WriteLine($"{number} is a prime number.")
            }
            else Console.WriteLine($"{number} is not a prime number");
    } 
}