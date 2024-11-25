using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FactoryPattern
    {
        
    }

    public interface IShape
    {
        void Draw();
    }

    public class Circle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    public class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    public class Triangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }
    }
}