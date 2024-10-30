namespace MyNamespace
{
    public interface IFlyable
    {
        void fly();
    }

    public class Bird:IFlyable
    {
        public void fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    public class AirPlane:IFlyable
    {
        public void fly()
        {
            Console.WriteLine("Airplane is flying.");
        }
    }
}