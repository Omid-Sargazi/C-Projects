using System;
namespace UnifiedType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 41;
            var employee = new Employee{Name="Omid",Age=42};
            Console.WriteLine("Number as a string:"+ number.ToString());
            Console.WriteLine("Employee as string:"+employee.ToString());


            object objectNumber = number;
            object objeEmployee = employee;
            Console.WriteLine("Number hash code: "+objectNumber.GetHashCode());
            Console.WriteLine("Employee hash code: "+ objeEmployee.GetHashCode());

            int originalNumber = (int)objectNumber;
            Employee originalEmployee = (Employee)objeEmployee;
            Console.WriteLine($"Original number: {originalNumber}, Original employee name: {originalEmployee.Name}");

            Console.WriteLine("//////////////////////////");
            IPaymentMethod paymentMethod;
            paymentMethod = new CreditCard  {CardNumber="12",CardHolder="54"};
            paymentMethod.ProcessPayment(20.36m);
            Console.WriteLine("//////////////////////////");
            /// 
            /// 
            /// 
            Console.WriteLine("//////////////////////////");
            var emailNotifier = new EmailNotification();
            var smsNotifier = new SMSNotification();
            var notificationService = new NotificationService();
            notificationService.NotificationSent += (msg) => Console.WriteLine($"Log: Notification sent - {msg}");
            notificationService.Notify(emailNotifier, "Hello via Email!");
        notificationService.Notify(smsNotifier, "Hello via SMS!");

        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Employee: {Name}, Age: {Age}";
        }
    }

    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCard: IPaymentMethod
    {
        public string CardNumber { get; set; }
        public string CardHolder {get; set; }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of ${amount} for {CardHolder}.");
        }
    }

    public class PayPal: IPaymentMethod
    {
        public string Email { get; set; }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount} for {Email}.");
        }
    }

    public interface ISendNotification
    {
        void Send(string message);
    }

    public class EmailNotification:ISendNotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SMSNotification:ISendNotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    public class NotificationService
    {
        public event Action<string> NotificationSent;

        public void Notify(ISendNotification notifier, string message)
        {
            notifier.Send(message);
            NotificationSent?.Invoke(message);
        }
    }
}