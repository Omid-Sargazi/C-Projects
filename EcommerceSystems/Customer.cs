namespace EcommerceSystems
{
    public class Customer
    {
        public int CustomerId {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
        public List<Order> Orders {get;set;} = new List<Order>();
    }

    public class Product
    {
        public int ProductId {get;set;}
        public string Name{get;set;}
        public decimal Price {get;set;}
        public List<OrderItem> OrderItems {get;set;} = new List<OrderItems>();
    }

    public class Order
    {
        public int OrderId {get;set;}
        public DateTime OrderDate {get;set;}
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Owner
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }
    }
}