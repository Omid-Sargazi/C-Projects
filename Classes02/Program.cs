using System;

namespace VehicleNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //  Car01 myCar = new Car01();
            // myCar.Model="Ford";
            // myCar.Year=2021;
            // myCar.PrintDetail();
            // Car02 myCar =new Car02("Tesla", 2023);
            // myCar.PrintDetail();

            // Car03 myCar = new Car03{Model="BMW",Year=2024};
            // myCar.PrintDetail();

            // Car04 myCar = new Car04();
            // myCar.PrintDetails();

            Car05 myCar = new Car05("Toyota");
            Car05 myCar02 = new Car05("Ford");
            Car05.PrintCarCount();



        }
    } 

    public class Car01
    {
        private string _model;
        private int _year;

        public string Model
        {
            get {return _model;}
            set { _model = value; }
        }

        public int Year{
            get {return _year;}
            set{ _year = value; }
        }

        public void PrintDetail()
        {
            Console.WriteLine($"Car Model: {Model}, Year: {Year}");
        }
    }


    public class Car02
    {
        private string _model;
        private int _year;

        public string Model =>_model;//Read only property

        public Car02(string model, int year)
        {
            _model=model;
            _year=year;
        }

        public void PrintDetail()
        {
            Console.WriteLine($"Car Model: {Model} , Year: {_year}");
        }
    }

    
    public class Car03
    {
        public string Model{get;set;}
        public int Year{get;set;}
        public void PrintDetail()
        {
            Console.WriteLine($"Car Model: {Model}, Year: {Year}");
        }
    }

    public class Car04
    {
        public string Model {get; set;}
        public int Year {set;get;}

        public Car04(){
            Model="Unknown";
            Year=0;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Car Model: {Model}, Year: {Year}");
        }
    }
   
   public class Car05
   {
    public static int CarCount=0;
    public string Model{get;set;}

    public Car05(string model)
    {
        Model=model;
        CarCount++;
    }
    public static void PrintCarCount()
    {
        Console.WriteLine($"Total Cars {CarCount}");
    }
   }
}
