namespace MyNamespace
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle starting...");
        }
    }


    public class Bike:Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike starting...");
        }
    }
    
}