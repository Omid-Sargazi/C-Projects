using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWebServer02.Interfaces.Logger
{
    public class ConsoleLogger : ILogger02
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}