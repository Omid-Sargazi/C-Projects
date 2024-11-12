namespace Generics
{
    public class PaginatedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public int pageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}