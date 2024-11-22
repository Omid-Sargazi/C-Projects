namespace UnifiedType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 41;
            var employee = 
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Employee: {Name}, Age{Age}";
        }
    }
}