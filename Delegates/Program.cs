namespace Delegates
{
    public class Program
    {
        delegate int Deleg1(int a, int b);  
        public static void Main(string[] args)
        {
           Deleg1 deleg1 = delegate(int a, int b){ return a + b; };
        }

       
    }
}