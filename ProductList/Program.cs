namespace IProduct
{
    public class Program
    {
        public static void Main(string[] args)
        {
          var products = new List<Product>
          {
            new Product{Id=1,Name="Laptop",Category="Electronics",Price=1200,StockQuantity=10,CreatedDate=DateTime.Now.AddMonths(-2)},
            new Product{Id=2,Name="SamrtPhone",Category="Electronics",Price=1500,StockQuantity = 15, CreatedDate = DateTime.Now.AddMonths(-1)}
          }   
        }
    }

}