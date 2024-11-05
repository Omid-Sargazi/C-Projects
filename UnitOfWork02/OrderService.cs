namespace UnitOfWOrk02
{
    private readonly CustomerRepository _customerRepository;
    private readonly OrderRepository _orderRepository;
    private readonly ProductRepository _productRepository;

    public OrderService(CustomerRepository customerRepository, OrderRepository orderRepository, ProductRepository productRepository)
    {
        _customerRepository = customerRepository;
        _orderRepository = orderRepository;
        _productRepository = productRepository;
    }

    public void PlaceOrder(int customerId, int productId, int quantity, decimal totalAmount)
    {
        var customer = _customerRepository.Find(customerId);
        var product = _productRepository.Find(productId);

        // Update product stock
        if (product != null)
        {
            product.Stock -= quantity;
            _productRepository.UpdateStock(productId, quantity);
        }

        // Deduct balance
        if (customer != null)
        {
            customer.Balance -= totalAmount;
            _customerRepository.Update(customer);
        }

        // Create order
        var order = new Order { CustomerId = customerId, ProductId = productId, Quantity = quantity, Status = "Pending", TotalAmount = totalAmount };
        _orderRepository.Add(order);
    }
}