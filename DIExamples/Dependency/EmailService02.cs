using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExamples.Dependency
{
    public class EmailService02 : IMessageService02
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}