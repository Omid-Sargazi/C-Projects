namespace MyNamespace
{
    public abstract class Employee
    {
        public abstract void Work();
    }

    public class Developer:Employee
    {
        public override void Work()
        {
        Console.WriteLine("Writing code.");        
        }
    }
}