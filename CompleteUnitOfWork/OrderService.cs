namespace UnitOfWorkComplete
{
    public class OrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void PlaceOrder(int customerId, int productId, int quantity)
        {
            var customer = _unitOfWork.Customers.Get(customerId);
            var product = _unitOfWork.Products.Get(productId);
            if (customer == null || product == null)
            throw new Exception("Customer or Product not found");

            if (product.Stock < quantity)
            throw new Exception("Insufficient stock");

            var order = new Order
        {
            CustomerId = customerId,
            ProductId = productId,
            Quantity = quantity,
            TotalAmount = product.Price * quantity,
            Status = "Pending"
        };
        product.Stock -= quantity;
        customer.Balance -= order.TotalAmount;

        _unitOfWork.Orders.Add(order);
        _unitOfWork.Products.Update(product);
        _unitOfWork.Customers.Update(customer);

        _unitOfWork.Complete(); // Commit all changes as a single transaction
        }
    }
}