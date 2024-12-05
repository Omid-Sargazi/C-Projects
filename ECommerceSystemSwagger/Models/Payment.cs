using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystemSwagger.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; } // e.g., Credit Card, PayPal
        public decimal Amount { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}