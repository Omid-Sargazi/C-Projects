namespace Generics
{
    public class Repository<T> where T:Entity
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T entity)=>_entities.Add(entity);
        public void Remove(T entity)=>_entities.Remove(entity); 
        public T GetById(int id)=>_entities.FirstOrDefault(e=>e.Id==id);
        public List<T> GetAll()=>_entities;

        ////////////////////////////////
        public T Find(Func<T,bool> predicate)=>_entities.FirstOrDefault(predicate);

        public void Update(int id, T updateEntity)
        {
            var entity = GetById(id);
            if(entity!=null)
            {
                _entities.Remove(entity);
                _entities.Add(updateEntity);
            }
        }
    }
}