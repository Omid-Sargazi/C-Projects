using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Circle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}