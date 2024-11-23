namespace Delegates
{
    public class Program
    {

        delegate void Deleg1(params int[] args);
        delegate void Deleg2(ref int a,int b);
       
        public static void Main(string[] args)
        {
            Deleg2 deleg2 = new Deleg2(Test1);
            int a=10;
            deleg2(ref a,20);
            Console.WriteLine("a is:"+a);

        //    Deleg1 deleg1 = new Deleg1(test);
        //    test(new int[] {1,2,3});
        //    test(1,2,3);
        }

        static void test(params int[] array)
        {
            int temp=0;
            foreach (int i in array)
            {
                temp+=i;
            }

            Console.WriteLine(temp);
        }

        static void Test1(ref int num1,int num2)
        {
            num1=100;
            Console.WriteLine($"num1+num2: {num1+num2}");
        }
    }
}