using System;

namespace SingeltonPatternn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            SingeltonPattern s1 = SingeltonPattern.GetInstance();
            Console.WriteLine("Instance"+s1 );
        }
    }


    public sealed class SingeltonPattern
    {
        private static  SingeltonPattern instance = null;

        private SingeltonPattern(){}
        public static SingeltonPattern GetInstance()
        {
            if(instance==null)
            {
                instance = new SingeltonPattern();
            }
            return instance;
        }
    }
}