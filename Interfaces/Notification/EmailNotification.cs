namespace Interfaces
{
    public class EmailNotification:INotification
    {
        public void Send(string message, string recepient)
        {
            Console.WriteLine($"Sending Email to {recepient}: {message}");
        }
    }
}