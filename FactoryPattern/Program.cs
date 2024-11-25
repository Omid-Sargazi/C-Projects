using System;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            // IPizza pizza = PizzaFactory.CreatePizza("peperonis");
            // pizza.Prepare();

            float myNum = 15000000L;
            Console.WriteLine(myNum);
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

    public class DarkButton:IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Dark Button.");
        }
    }

    public class DarkCheckbox:IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Dark Checkbox.");
        }
    }

    public interface IUIFactory
    {
        public IButton createButton();
        public ICheckBox createCheckBox();
    }

    public class LightThemeFactory:IUIFactory
    {
        public IButton createButton()
        {
            return new LightButton();
        }

        public ICheckBox createCheckBox()
        {
            return new LightCheckBox();
        }
    }

    public class DarkThemeFactory:IUIFactory
    {
        public IButton createButton()
        {
            return new DarkButton();
        }


        public ICheckBox createCheckBox()
        {
            return new DarkCheckBox();
        }
    }

    ////////////////Abstract Factory/////////////////////////////////////
    
    public interface ICardPayment
    {
        void ProcessCardPayment(decimal amount);
    }

    public interface IBankTransfer
    {
        void ProcessBankTransfer(decimal amount);
    }

    public class USACardPayment:ICardPayment
    {
        public void ProcessCardPayment(decimal amount)
        {
            Console.WriteLine($"Processing USA card payment of ${amount}.");
        }
    }

    public class USABankTransfer:IBankTransfer
    {
        public void ProcessBankTransfer(decimal amount)
        {
            Console.WriteLine($"Processing USA bank transfer of ${amount}.");
        }
    }

    public class EuropeCardPayment:ICardPayment
    {
        public void processCardPayment(decimal amount)
        {
            Console.WriteLine($"Processing Europe card payment of €{amount}.");
        }
    }

    public class EuropeBankTransfer:IBankTransfer
    {
        public void ProcessBankTransfer(decimal amount)
        {
            Console.WriteLine($"Processing Europe bank transfer of €{amount}.");
        }
    }

    public interface IPaymentFactory
    {
        ICardPayment CreateCardPayment();
        IBankTransfer CreateBankTransfer();
    }

    public class USAPaymentFactory:IPaymentFactory
    {
        public ICardPayment CreateCardPayment()
        {
            return new USACardPayment();
        }

        public IBankTransfer CreateBankTransfer()
        {
            return new USABankTransfer();
        }
    }

    public class EuropePaymentFactory:IPaymentFactory
    {
        public ICardPayment CreateCardPayment()
        {
            return new EuropeCardPayment();
        }

        public IBankTransfer CreateBankTransfer()
        {
            return new EuropeBankTransfer();
        }
    }
}