namespace Delegates
{
    public class Program
    {
       delegate void Deleg1(int a,int b);
       delegate void Deleg2(int a, int b);

       delegate int Deleg3(int a, int b);
        public static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Deleg1 delg1 = new Deleg1(Sum);

            Deleg2 deleg2 = new Deleg2(Minus);
            deleg2(100,50);
            // Deleg1 delg1 = Sum;
            delg1(3,2);


            Deleg3 deleg3 = new Deleg3(MUltiple);
            Console.WriteLine(deleg3(4,3));
        }
 
        static void Sum(int num1, int num2)
        {
            Console.WriteLine($"Sum:  {num1+num2}");
            
        }
        static void Minus(int num1, int num2)
        {
            Console.WriteLine($"Minus: , {num1-num2}");

        }
        static int MUltiple(int num1, int num2)
        {
            return num1*num2;
        }
    }
}