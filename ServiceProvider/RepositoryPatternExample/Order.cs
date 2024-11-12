using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } // Navigation Property to Customer
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // Navigation Property to OrderItems
    }
}