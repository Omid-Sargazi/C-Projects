namespace PaymentProcessor
{
    public class PayPalPaymentProcessor:BasePaymentProcessor
    {
        public override decimal CalculateFees(decimal amount)
    {
        return amount * 0.03m + 0.30m; // 3% fee plus $0.30 fixed fee
    }

    public override void ProcessPayment(decimal amount)
    {
        decimal totalAmount = amount + CalculateFees(amount);
        Console.WriteLine($"Processing PayPal Payment: Total Amount: {totalAmount}");
        SendReceipt();
    }

    public override void SendReceipt()
    {
        Console.WriteLine("PayPal Receipt sent with transaction details.");
    }
    }
}