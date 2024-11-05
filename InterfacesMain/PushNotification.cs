namespace MainInterface
{
    public class PushNotification:INotification
    {
        public bool Send(NotificationContext context)
        {
            try{
                Console.WriteLine($"Sending Push Notification to {context.Recipient}: {context.Message}");
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine($"Failed to send push notification: {ex.Message}");
                return false;
            }
        }
    }
}