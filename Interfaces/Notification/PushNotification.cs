namespace Interfaces
{
    public class PushNotification:INotification
    {
        public void Send(string message, string recepient)
        {
            Console.WriteLine($"Sending Push Notification to {recepient}: {message}");
        }
    }
}