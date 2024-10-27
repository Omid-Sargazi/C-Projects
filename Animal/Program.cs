using System;

namespace  Class_Animal
{
    public class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Dog dog = new Dog();
            dog.Eat();

            Dogg dogg = new Dogg();
            dogg.Sound();
        }
    }


    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Dog:Animal
    {
    }

    public class Animall
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }


    public class Dogg:Animall
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barkss");
        }
    }
}

