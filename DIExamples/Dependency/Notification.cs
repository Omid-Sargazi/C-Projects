using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExamples.Dependency
{
    public class Notification
    {
        private readonly IMessageService02 _messageService02;

        public Notification(IMessageService02 messageService02)
        {
            _messageService02=messageService02;
        }

        public void Notify(string message)
        {
            _messageService02.SendMessage(message);
        }
    }
}