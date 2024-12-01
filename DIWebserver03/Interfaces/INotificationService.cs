using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWebserver03.Interfaces
{
    public interface INotificationService
    {
        void Notify(string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email Notification Sent: {message}");
        }
    }
}