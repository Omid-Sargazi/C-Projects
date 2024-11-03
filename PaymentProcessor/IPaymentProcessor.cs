namespace PaymentProcessor
{
    public interface IPaymentProcessor
    {
        decimal CalculateFees(decimal amount);
        void ProcessPayment(decimal amount);
        void SendReceipt();
    }
}