namespace EcommerceSystem.Repository
{
    public class Repository<T> :IRepository<T> where T:class
    {
        private readonly EcommerceContext _context;
        public Repository(EcommerceContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        
    }
}