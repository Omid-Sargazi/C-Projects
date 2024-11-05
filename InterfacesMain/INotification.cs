namespace MainInterface
{
    public interface INotification
    {
        bool Send(NotificationContext context);
    }
}