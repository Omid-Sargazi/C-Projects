namespace MainInterface
{
    public class NotificationContext
    {
        public string Recipient {get;set;}
        public string Message {get;set;}

        public string Subject {get;set;}

        public NotificationContext(string recipient, string message, string subject="")
        {
            Recipient=recipient;
            Message=message;
            Subject=subject;
        }
    }
}