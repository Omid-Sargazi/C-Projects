namespace PaymentProcessor
{
    public abstract class BasePaymentProcessor:IPaymentProcessor
    {
        public abstract decimal CalculateFees(decimal amount);
        public abstract void ProcessPayment(decimal amount);
        public virtual void SendReceipt()
        {
            Console.WriteLine("Receipt sent to customer.");
        }
    }
}