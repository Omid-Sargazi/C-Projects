using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number: "+ ReverseNumber(number));
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
}