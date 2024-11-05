namespace ShoppingOnline
{
    public interface IOrderItem
    {
        decimal CalculatePrice();
        void ProcessOrder();
    }
}