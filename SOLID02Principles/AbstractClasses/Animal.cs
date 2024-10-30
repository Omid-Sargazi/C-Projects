namespace MyNamespace
{
    public abstract class Animall{
        public abstract void Speak();
    }


    public class Cat:Animall
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}