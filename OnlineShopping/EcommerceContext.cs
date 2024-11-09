namespace EcommerceContext
{
    public class EcommerceContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public Dbset<Owner> Owners { get; set; }

        public EcommerceContext(DbContextOptions<EcommerceContext> options):base(options){}
    }

}