using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExamples.Dependency
{
    public class SmsService : IMessageService02
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}