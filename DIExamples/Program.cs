using DIExamples.Dependency;
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

            // var serviceProvider = new ServiceCollection()
            // .AddTransient<IMessageService,EmailService>()
            // .BuildServiceProvider();

            // var notification = new Notification(serviceProvider.GetService<IMessageService>());
            // notification.Notify("Hello using DI Container");

        //     IMessageService02 emailService = new EmailService02();
        //    Notification notification = new Notification(emailService);
        //    notification.Notify("hello");
        //    IMessageService02 smsService = new SmsService();
        //    Notification notification1 = new Notification(smsService);
        //    notification.Notify("sms service");

        var serviceProvider = new ServiceCollection()
        .AddTransient<IMessageService02,EmailService02>()
        .BuildServiceProvider();

        var notification = new Notification(serviceProvider.GetService<IMessageService02>());
        notification.Notify("Dependancy injection with packages");


        }
    }
}