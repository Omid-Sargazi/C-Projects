namespace UnitOfWorkComplete
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public Product Get(int id) => _context.Products.Find(id);
        public IEnumerable<Product> GetAll() => _context.Products.ToList();

        public void Add(Product product) => _context.Products.Add(product);

        public void Update(Product product) => _context.Products.Update(product);

        public void Remove(Product product) => _context.Products.Remove(product);
    }
}