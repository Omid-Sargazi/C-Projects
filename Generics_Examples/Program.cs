using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            var productRepo = new Repository<Product>();
            productRepo.Add(new Product{Id=1,Name="Laptop",Price=1500});
            productRepo.Add(new Product{Id=2,Name="Smartphone",Price=800});

            var allProducts = productRepo.GetAll();
            foreach(var product in allProducts)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            ///////////Customer
            var customerRepo = new Repository<Customer>();
            customerRepo.Add(new Customer{Id=1,FullName="Omid",Email="O@gmail.com"});
            customerRepo.Add(new Customer{Id=2,FullName="Saeed",Email="Sa@gmail.com"});

            var allCustomers = customerRepo.GetAll();
            foreach(var person in allCustomers)
            {
                Console.WriteLine($"Customer ID: {person.Id}, FullName: {person.FullName}, Email: {person.Email}");
            }
            //////////// Finding an Entity by a Condition
            var expensiveProduct = productRepo.Find(p=>p.Price>1000);
            Console.WriteLine($"Expensive Product: {expensiveProduct?.Name}, Price: {expensiveProduct?.Price}");
            productRepo.Update(1, new Product{Id=1,Name="Laptop pro",Price=1900});
            var updatedProduct = productRepo.GetById(1);
            Console.WriteLine($"Updated Product: {updatedProduct.Name}, Price: {updatedProduct.Price}");
            /////////////////////////////////////////////////Generic Service Class for Logging
            var logger = new Logger<string>();
            logger.Log("This is a log message");

            var intLogger = new Logger<int>();
            intLogger.Log(158);
            //////////////////Generic Validator Class
            var priceValidator = new Validator<Product>();
            bool isValid = priceValidator.isValid(new Product{Price=1200},p=>p.Price<1000);
            Console.WriteLine($"Is the product valid? {isValid}");

            
            //////////////////////////////
            var paginatedProducts = new PaginatedResult<Product>
            {
                Items = productRepo.GetAll().Take(2).ToList(),
                TotalCount = productRepo.GetAll().Count(),
                pageSize=2,
                CurrentPage=1
            };

            Console.WriteLine($"Page {paginatedProducts.CurrentPage}/{(paginatedProducts.TotalCount + paginatedProducts.pageSize - 1) / paginatedProducts.pageSize}");
            
            foreach (var product in paginatedProducts.Items)
                {
                    Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                }

                //////////////////////////////Caching Service with Generic Types
                var cache = new CacheService<Product>();
                cache.Add("product1",new Product{Id=3,Name="PC",Price=870});
                var cachedProduct = cache.Get("product1");
                Console.WriteLine($"Cached Product: {cachedProduct.Name}, Price: {cachedProduct.Price}");

                var allProductss = productRepo.GetAll();
            foreach(var product in allProductss)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            

            
            
        }

        
    }
}