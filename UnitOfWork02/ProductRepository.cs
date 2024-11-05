namespace UnitOfWOrk02
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public void UpdateStock(int productId, int quantity)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                product.Stock -= quantity;
                _context.SaveChanges();
            }
        }

        public Product Find(int productId)
        {
            return _context.Products.Find(productId);
        }
    }
}