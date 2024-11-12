namespace ExampleOfGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var productRepo = new Repository<Product>();
            productRepo.Add(new Product{Id=1,Name="LapTop",Price=1200});
            productRepo.Add(new Product{Id=2,Name="SamrtPhone",Price=500});

            var expensiveProduct = productRepo.Find(p=>p.Price>1000);
            // Console.WriteLine($"Expensive Product: {expensiveProduct?.Name}, Price: {expensiveProduct?.Price}");

            productRepo.Update(1,new Product{Id=1,Name="Laptop pro",Price=1980});
            var productedUpdate = productRepo.GetById(1);
            Console.WriteLine($"Updated Product: {productedUpdate.Name}, Price: {productedUpdate.Price}");



            var allProducts = productRepo.GetAll();
            foreach (var product in allProducts)
            {
                // Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            var Logger= new Logger<string>();
            Logger.Log("This is a log message.");
            var intLogger = new Logger<int>();
            intLogger.Log(152);
        }
    }
}