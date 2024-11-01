namespace Interfaces
{
    public class SmsNotification:INotification
    {
        public void Send(string message, string recepient)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }
}