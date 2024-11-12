using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } // Navigation Property to Product
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.Price * Quantity;
    }
}