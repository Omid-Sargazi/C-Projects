using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIWebserver03.Interfaces;

namespace DIWebserver03.Implements
{
    public class ConsoleLogger : ILoggers
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}