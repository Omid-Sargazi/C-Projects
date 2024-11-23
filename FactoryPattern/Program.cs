﻿using System;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            IPizza pizza = PizzaFactory.CreatePizza("peperonis");
            pizza.Prepare();
        }
    }

    public interface IPizza
    {
        void Prepare();
    }

    public class CheesePizza:IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Veggie Pizza...");
        }
    }

    public class PepperoniPizza:IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Pepperoni Pizza...");
        }
    }

    public class PizzaFactory
    {
        public static IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "peperoni":
                    return new PepperoniPizza();
                case "cheese":
                return new CheesePizza();
                default:
                throw new ArgumentException("enter a valid name.. ");
            }

        }
    }



    ////////////////////////////////////Abstarct Factory//////////////////////////////////////////////
    
    public interface IButton
    {
        void Render();
    }

    public interface ICheckBox
    {
        void Render();
    }

    public class LightButton:IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Light Button.");
        }
    }

    public class LightCheckbox:ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Light Checkbox.");
        }
    }

}