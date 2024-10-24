using System;
namespace VehicleNamespace
{
    public class Car
{
    public string Model;
    public int year;

    public void PrintDetails()
    {
        Console.WriteLine($"Car Model: {Model},Year: {year}");
    }
}

public class Carr
{
    public string Model;
    public int Year;

    public Carr(string model, int year)
    {
        Model=model;
        Year=year;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Car Model: {Model}, Year: {Year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Car  myCar = new Car();
        // myCar.Model = "Toyota";
        // myCar.year=2020;
        // myCar.PrintDetails();

        Carr myCar = new Carr("Honda", 2022);
        myCar.PrintDetails();
    }
}

}
