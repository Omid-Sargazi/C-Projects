using System;

namespace UnitOfWOrk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }

    public class Product
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public int Stock{get;set;}
    }

    public class Order
    {
        public int Id{get;set;}
        public int ProductId{get;set;}
        public int Quantity{get;set;}
        
    }

    public class Customer
    {
        public int Id{get;set;}
        public string Name {get;set;}
        public decimal Balance{get;set;}
    }

    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context=context;
        }

        public void UpdateStock(int productID, int quantity)
        {
            var product = _context.Products.Find(productID);
            if (product != null)
        {
            product.Stock -= quantity;
            _context.SaveChanges();  // Commits immediately
        }
        }
    }

    public class OrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();  // Commits immediately
    }
    }

    public class CustomerRepository{
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public void DeductBalance(int customerId, decimal amount)
    {
        var customer = _context.Customers.Find(customerId);
        if (customer != null)
        {
            customer.Balance -= amount;
            _context.SaveChanges();  // Commits immediately
        }
    }
    }
}