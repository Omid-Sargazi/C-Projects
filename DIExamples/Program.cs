using DIExamples.DI;

namespace DIExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMessageService emailService = new EmailService();
            Notification notification= new Notification(emailService);
            notification.Notify("Hello, Dependency Injection!");
        }
    }
}