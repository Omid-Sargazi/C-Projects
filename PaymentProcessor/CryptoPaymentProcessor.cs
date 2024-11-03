namespace PaymentProcessor
{
    public class CryptoPaymentProcessor:BasePaymentProcessor
    {
        public override decimal CalculateFees(decimal amount)
        {
            return amount * 0.01m;
        }

        public override void ProcessPayment(decimal amount)
        {
            decimal discountedAmount = amount - CalculateFees(amount);
            Console.WriteLine($"Processing Crypto Payment: Total Amount: {discountedAmount}");
            SendReceipt();
        }

        public override void SendReceipt()
        {
        Console.WriteLine("Crypto Payment Confirmation sent to wallet.");
         }
    }
}