namespace Repository
{
    public class Repository<T> where T:Entity
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T entity) => _entities.Add(entity);
        public void Remove(T entity) => _entities.Remove(entity);
        public T GetById(int id) =>_entities.FirstOrDefault(x => x.Id==id);
        public List<T> GetAll()=>_entities;
    }
}