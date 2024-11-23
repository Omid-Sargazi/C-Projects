using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if(string.IsNullOrEmpty(shapeType)) return null;
        switch (shapeType)
        {
            case "circle":
                return new Circle();
            case "rectangle":
                return new Rectangle();
            case "triangle":
                return new Triangle();
            
            default:
                throw new ArgumentException("Invalid Shape type");
        }
        }
    }
}