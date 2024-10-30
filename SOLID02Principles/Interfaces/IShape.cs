namespace MyNamespace
{
    public interface IShape
    {
        void Draw();
    }

    public class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}