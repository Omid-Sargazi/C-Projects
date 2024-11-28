namespace EventInCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string name="omid";

            // Action<string> greet = name=>Console.WriteLine($"Hello: {name}");
            Action<string> greet = name=>Console.WriteLine(name);
            greet(name);
            
            
        }
    }
}