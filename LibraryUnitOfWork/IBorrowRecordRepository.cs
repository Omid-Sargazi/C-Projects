namespace Librray
{
    public interface IBorrowRecordRepository
    {
        BorrowRecord Get(int id);
        IEnumerable<BorrowRecord> GetAll();
        void Add(BorrowRecord borrowRecord);
        void Update(BorrowRecord borrowRecord);
        void Remove(BorrowRecord borrowRecord);
    }
}