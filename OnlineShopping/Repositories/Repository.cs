namespace EcommerceSystem.Repository
{
    public class Repository<T> :IRepository<T> where T:class
    {
        private readonly EcommerceContext _context;
        public Repository(EcommerceContext context)
        {
            _context = context;
        }
    }
}