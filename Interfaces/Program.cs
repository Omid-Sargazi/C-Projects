using System;

namespace Interfaces
{
    public class Interfaces{
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            INotification emailNotification  = new EmailNotification();
            NotificationService emailServeice = new NotificationService(emailNotification);
            emailServeice.Notify("Hello via Email", "O@gmail.com");
        }
    }
}