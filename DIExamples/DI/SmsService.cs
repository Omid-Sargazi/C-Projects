using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExamples.DI
{
    public class SmsService:IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}