using System;
namespace DbSet_examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var newProduct = new Product{Name="Laptop",Price=1500};
            ApplicationDbContext _context = new ApplicationDbContext();
            _context.Products.Add(newProduct);
            _context.SaveChanges();

            var products = _context.Products.Where(p=>p.Price>100).ToList();
            Console.WriteLine(products.Price);
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}