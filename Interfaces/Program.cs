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

            emailNotification = new SmsNotification();
             NotificationService  sms = new NotificationService(emailNotification);
             sms.Notify("Hello via SMS!", "+123456789");

             emailNotification = new PushNotification();
             NotificationService pushService = new NotificationService(emailNotification);
             pushService.Notify("Hello via Push Notification!", "user123");


        }
    }
}