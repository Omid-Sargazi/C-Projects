namespace Interfaces
{
    public class NotificationService
    {
        private readonly INotification _notification;

        public NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message, string recepient)
        {
            _notification.Send(message, recepient);
        }
    }
}