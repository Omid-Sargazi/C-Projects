namespace Interfaces
{
    public class PushNotification
    {
        public void Send(string message, string recepient)
        {
            Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
        }
    }
}