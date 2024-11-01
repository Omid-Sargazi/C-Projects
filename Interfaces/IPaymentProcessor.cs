using Interfaces;

namespace Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}

public class CreditCardProcessor:IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}