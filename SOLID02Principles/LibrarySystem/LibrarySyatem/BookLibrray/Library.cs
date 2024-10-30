namespace LibrarySystem
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ListBook()
        {
            foreach(var book in books)
            {
                Console.WriteLine(book.GetBookInfo());
            }
        }
    }
}