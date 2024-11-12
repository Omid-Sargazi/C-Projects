namespace Generics
{
    public class CacheService<T>
    {
        private readonly Dictionary<string,T> _catch = new Dictionary<string, T>();

        public void Add(string key, T value) =>_catch[key]=value;
        public T Get(string key)=>_catch.ContainsKey(key) ? _catch[key]:default;
    }
}