using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIWebserver03.Interfaces;

namespace DIWebserver03.Business
{
    public class BusinessServiceProperty
    {
        public ILoggers loggers1 { get; set; }

        public void PerformTask()
        {
            if(loggers1 != null)
            {
                loggers1.Log("it is not null..");
            }
            else
            {
                Console.WriteLine("Logger is not set.");
            }
        } 
    }
}