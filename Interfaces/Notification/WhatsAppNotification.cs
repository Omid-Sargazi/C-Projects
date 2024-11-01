namespace Interfaces
{
    public class WhatsAppNotification:INotification
    {
        public void Send(string message, string recipient)
        {
            Console.WriteLine($"Sending WhatsApp message to {recipient}: {message}");
        }
    }
}