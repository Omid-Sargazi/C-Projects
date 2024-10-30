using System;
namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            // Book book1 = new Book();
            // book1.Title = "C# Programming";
            // book1.Author = "John Doh";
            // book1.DidplayInfo();

            // Student student =  new Student();
            // student.Age=25;
            // student.DisplayInfo();

            // Calculator calc = new Calculator();
            // int result = calc.Add(3,4);
            // Console.WriteLine(result);

            // Cars car1 = new Cars("Benz");
            // Console.WriteLine("Model is: " +car1.Model);

            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Shape shape = new Circle();
            shape.Draw();

            Animall cat = new Cat();
            cat.Speak();

            IFlyable flyable = new Bird();
            flyable.fly();

            flyable = new AirPlane();
            flyable.fly();
        }
    }
}