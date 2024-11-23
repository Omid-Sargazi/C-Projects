namespace Delegates
{
    public class Program
    {

        delegate void Deleg1(params int[] args);
       
        public static void Main(string[] args)
        {
           Deleg1 deleg1 = new Deleg1(test);
           test(new int[] {1,2,3});
           test(1,2,3);
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
    }
}