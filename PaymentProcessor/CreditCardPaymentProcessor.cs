namespace PaymentProcessor
{
    public class CreditCardPaymentProcessor:BasePaymentProcessor
    {
        public override decimal CalculateFees(decimal amount)
        {
            return amount * 0.02m;
        }

        public override void ProcessPayment(decimal amount)
        {
            decimal totalAmount = amount + CalculateFees(amount);
            Console.WriteLine($"Charging Credit Card: Total Amount: {totalAmount}");
            SendReceipt();
        }

         public override void SendReceipt()
    {
        Console.WriteLine("Credit Card Payment Receipt sent via Email.");
    }
    }
}