namespace PaymentProcessor
{
    public class PaymentHandler
    {
        private readonly List<IPaymentProcessor> _paymentProcessor;

        public PaymentHandler()
        {
            _paymentProcessor = new List<IPaymentProcessor>();
        }

        public void AddPaymentProcessor(IPaymentProcessor processor)
        {
            _paymentProcessors.Add(processor);
        }

        public void ProcessAllPayments(decimal amount)
        {
        foreach (var processor in _paymentProcessors)
            {
                processor.ProcessPayment(amount);
                Console.WriteLine("-----");
            }
        }
    }
}