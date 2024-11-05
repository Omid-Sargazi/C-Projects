namespace UnitOfWOrk02
{
    public class AppDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set;}   
        public DbSet<Order> Orders { get; set;} 
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("YourConnectionString");
    }
}