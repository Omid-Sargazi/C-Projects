using ShoppingOnline;

namespace ShoppingOnline
{
    public class DigitalProduct:IOrderItem
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string DownloadLink { get; set; }

        public decimal CalculatePrice()
        {
            decimal tax = Price * 0.15M; // 15% tax for digital products
            return Price + tax;
        }

        public void ProcessOrder()
    {
        Console.WriteLine("Processing Digital Product Order...");
        Console.WriteLine($"Download link generated: {DownloadLink}");
        Console.WriteLine($"Total Price with Tax: {CalculatePrice()}");
    }


    }
}