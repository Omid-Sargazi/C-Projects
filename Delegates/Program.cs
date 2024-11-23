namespace Delegates
{
    public class Program
    {
        delegate int Deleg1(int a, int b);  
        delegate void Deleg3();
        public static void Main(string[] args)
        {
           Deleg1 deleg1 = delegate(int a, int b){ 
            Console.WriteLine("Hello");
            return a + b; };
           int result = deleg1(100,20);
           Console.WriteLine(result);

           Deleg1 deleg2 = (x,y)=>x+y;
           int result2 = deleg2(1000,200);
           Console.WriteLine(result2);

        }

       
    }
}