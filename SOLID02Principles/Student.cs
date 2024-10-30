using System;
namespace MyNamespace
{
  public class Student
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative.");
            age = value;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("age is: " + age);
    }
}
}