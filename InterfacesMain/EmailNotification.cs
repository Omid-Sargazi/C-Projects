namespace MainInterface
{
    public class EmailNotification:INotification
    {
        public bool Send(NotificationContext context)
        {
            try
            {
                 Console.WriteLine($"Sending Email to {context.Recipient} with subject '{context.Subject}': {context.Message}");
            }catch(Exception ex)
            {
                 Console.WriteLine($"Failed to send email: {ex.Message}");
                 return false;
            }
        }
    }
}