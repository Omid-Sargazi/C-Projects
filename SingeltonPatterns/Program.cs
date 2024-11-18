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
            Console.WriteLine("///////////////////////////////////////////");

            Logger log1 = Logger.GetInstance();
            Console.WriteLine($"Instance of Log is: "+ log1);
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


    public sealed class Logger
    {
        private static Logger _instance;

        private Logger()
        {
            Console.WriteLine("Logger Initialized");
        }

        public static Logger GetInstance()
        {
            if(_instance==null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log:{message}");
        }
    }
}