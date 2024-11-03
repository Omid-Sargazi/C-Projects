namespace Shipping
{
    public class OrderProcessor
    {
        private readonly List<IOrderItem> _orderItems;

        public OrderProcessor()
        {
            _orderItems = new List<IOrderItem>();
        }

        public void AddItem(IOrderItem item)
        {
            _orderItems.Add(item);
        }

        public void ProcessAllOrders()
        {
            foreach(var item in _orderItems)
            {
                item.ProcessOrder();
                Console.WriteLine("-----");
            }
        }
    }
}