namespace MyNamespace
{
    public class Library
    {
        private List<string> books = new List<string>();

        public void AddBook(string book)
        {
            books.Add(book);
        } 

        public List<string> GetBook()
        {
            return new List<string>(books);
        }
    }
}