namespace Librray
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime BorrowBook {get;set;}
        public DateTime? ReturnDate { get; set; }
        public Book Book { get; set; }

    }
}