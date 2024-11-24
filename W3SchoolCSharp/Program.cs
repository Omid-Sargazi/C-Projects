using System;
namespace W3SchoolCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello");

            long largeNumber = 9223372L;
            int num1 = Convert.ToInt32(largeNumber);
            Console.WriteLine("int32"+largeNumber);
            Console.WriteLine(num1);
            string num2 = Convert.ToString(num1);
            Console.WriteLine("string num2: "+num2);
            bool num3 = Convert.ToBoolean(num1);

            Console.WriteLine("Boolean: "+num3);
            Console.WriteLine(largeNumber);



        }
    }
}