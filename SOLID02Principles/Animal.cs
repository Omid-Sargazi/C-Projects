namespace MyNamespace
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }


    public class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}