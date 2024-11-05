namespace MainInterface
{
    public class SmsNotification:INotification
    {
        public bool Send(NotificationContext context)
        {
            try
            {
                Console.WriteLine($"Sending SMS to {context.Recipient}: {context.Message}");
                
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine($"Failed to send SMS: {ex.Message}");
                return false;
            }
        }
    }
}