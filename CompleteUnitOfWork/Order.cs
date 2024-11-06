namespace UnitOfWorkComplete
{
    public class Order
    {
        public int Id{get;set;}
        public int CustomerId{get;set;}
        public int ProductId{get;set;}
        public int Quantity{get;set;}
        public string Status{get;set;}
        public decimal TotalAmount { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}