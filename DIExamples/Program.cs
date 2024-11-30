using DIExamples.DI;
using Microsoft.Extensions.DependencyInjection;

namespace DIExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // IMessageService emailService = new EmailService();
            // Notification notification= new Notification(emailService);
            // IMessageService smsService = new SmsService();
            // Notification notification1 = new Notification(smsService);
            // notification1.Notify("Hello via SMS!");
            // notification.Notify("Hello, Dependency Injection!");

            var serviceProvider = new ServiceCollection()
            .AddTransient<IMessageService,EmailService>()
            .BuildServiceProvider();

            var notification = new Notification(serviceProvider.GetService<IMessageService>());
            notification.Notify("Hello using DI Container");
        }
    }
}