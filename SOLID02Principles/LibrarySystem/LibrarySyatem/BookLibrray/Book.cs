namespace LibrarySystem
{
    public class Book
    {
        public string Title{get;set;}
        public string Author{get;set;}
        public string ISBN {get;set;}

        public string GetBookInfo()
        {
            return $"{Title} by {Author} (ISBN: {ISBN})";
        }
    }
}