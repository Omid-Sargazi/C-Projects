namespace Shopping
{
    public interface IOrderItem
    {
        decimal CalculatePrice();
        void ProcessOrder();
    }
}