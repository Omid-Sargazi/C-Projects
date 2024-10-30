namespace MyNamespace
{
    public interface IDriveablee
    {
        void Drive();
    }

    public class Vehiclee
    {
        public void Start()
        {
            Console.WriteLine("Vehicle starting...");
        }
    }

    public class Carr:Vehiclee, IDriveablee
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }
}