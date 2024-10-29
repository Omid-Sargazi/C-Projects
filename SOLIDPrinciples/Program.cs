using System;

namespace MyNamespace
{
   public class Program
   {
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        var products = new List<IProducts>{new Electronics{Id=1, Name="TV"}, new Grocery{Id=2, Name="Milk"}};
        var discountableProducts = products.OfType<IDiscountable>();

       foreach (var discountable in discountableProducts)
{
    decimal originalPrice = 1000m; // Assume an example price
    decimal discountedPrice = discountable.ApplyDiscount(originalPrice);
    Console.WriteLine($"Discounted price for {((IProducts)discountable).Name}: {discountedPrice:C}");
}
    }
   }
}