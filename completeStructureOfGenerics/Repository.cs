namespace CompleteStrcture
{
    public class Repository<T> where T:class
    {
        private readonly List<T> _entities;

        public Repository(List<T> entities)
        {
            _entities=entities;
        }

        public T Find(Func<T,bool> predicate)=>_entities.FirstOrDefault(predicate);

        public IEnumerable<T> GetAll()=>_entities;

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public bool Remove(Func<T,bool> prediacte)
        {
            var entity = _entities.FirstOrDefault(prediacte);
            if (entity != null)
            {
                _entities.Remove(entity);
                Console.WriteLine("Entity removed successfully.");
                return true;
            }else{
                return false;
            }
        }

        public bool Update(T updateEntity, Func<T,bool> prediacte)
        {
            var index = _entities.FindIndex(e=>prediacte(e));
            if(index>=0)
            {
                _entities[index]=updateEntity;
                Console.WriteLine("Entity updated successfully.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}