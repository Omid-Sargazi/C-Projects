using System;

namespace Classes_inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Shape circle = new Circle(5);
            Console.WriteLine(circle.Area());
        }
    }

    public abstract class Shape{
        public abstract double Area();
    }

    public class Circle:Shape{
        public double Radius{get; set;}
        public Circle(double radius) => Radius = radius;

       public override double Area() => Math.PI * Radius * Radius;
    }
}