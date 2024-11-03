using System;

namespace ShoppingOnline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();

        // Add a physical product
        var book = new PhysicalProduct
        {
            ProductName = "Book: Clean Code",
            Price = 30.00M,
            Weight = 1.5 // kg
        };
        orderProcessor.AddItem(book);

        // Add a digital product
        var eBook = new DigitalProduct
        {
            ProductName = "E-Book: Design Patterns",
            Price = 25.00M,
            DownloadLink = "http://example.com/download"
        };
        orderProcessor.AddItem(eBook);

        // Process All Orders
        orderProcessor.ProcessAllOrders();


        }
    }
}