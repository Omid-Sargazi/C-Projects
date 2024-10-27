using System;

namespace  Class_Animal
{
    public class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Dog dog = new Dog();
            dog.Eat();
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
}

