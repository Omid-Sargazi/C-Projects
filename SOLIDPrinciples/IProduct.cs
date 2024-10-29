// public interface IProduct
// {
//     int Id { get; }
//     string Name { get; }
// }

// public interface IDiscountable
// {
//     decimal ApplyDiscount(decimal price);
// }

// public class Electronic : IProduct, IDiscountable
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public decimal ApplyDiscount(decimal price) => price * 0.9m;
// }

// public class Grocery : IProduct
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
// }

// var products = new List<IProduct>
// {
//     new Electronic { Id = 1, Name = "TV" },
//     new Grocery { Id = 2, Name = "Milk" }
// };

// var discountableProducts = products.OfType<IDiscountable>();

// foreach (var discountable in discountableProducts)
// {
//     decimal originalPrice = 1000m; // Assume an example price
//     decimal discountedPrice = discountable.ApplyDiscount(originalPrice);
//     Console.WriteLine($"Discounted price for {((IProduct)discountable).Name}: {discountedPrice:C}");
// }
