using System;

class Program
{
    static void Main(string[] args)
    {
    
    Console.WriteLine("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number: "+ ReverseNumber(number));

    Console.WriteLine("Enetr a string");
    string s = Console.ReadLine();
    int count=0;
    Console.WriteLine("Enter the character to count:");
    char character = Console.ReadLine()[0];
    count = CountCharater(s,character);
    Console.WriteLine("the count of the string is : "+count);
}
   static int ReverseNumber(int num)
   {
    static int helper(int num, int reverse)
    {
        if(num==0) return reverse;
        return helper(num/10, num%10+reverse*10);
    }
    return helper(num, 0);
   }

   static int CountCharater(string s, char C)
   {
    int count=0;
    foreach(char c in s)
    {
        if(c==C) count++;
    }
    return count;
   }
}