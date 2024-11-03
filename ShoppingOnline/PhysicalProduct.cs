using ShoppingOnline;
namespace ShoppingOnline
{
    public class PhysicalProduct:IOrderItem
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
    public decimal CalculatePrice()
    {
        decimal shippingCost = (decimal)Weight*0.5M;
        return Price+shippingCost;
    }

    public void ProcessOrder()
    {
        Console.WriteLine("Processing Physical Product Order...");
        Console.WriteLine($"Shipping Label generated for: {ProductName}");
        Console.WriteLine($"Total Price with Shipping: {CalculatePrice()}");
    }
    }

}