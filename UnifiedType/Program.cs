using System;
namespace UnifiedType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 41;
            var employee = new Employee{Name="Omid",Age=42};
            Console.WriteLine("Number as a string:"+ number.ToString());
            Console.WriteLine("Employee as string:"+employee.ToString());


            object objectNumber = number;
            object objeEmployee = employee;
            Console.WriteLine("Number hash code: "+objectNumber.GetHashCode());
            Console.WriteLine("Employee hash code: "+ objeEmployee.GetHashCode());

            int originalNumber = (int)objectNumber;
            Employee originalEmployee = (Employee)objeEmployee;
            Console.WriteLine($"Original number: {originalNumber}, Original employee name: {originalEmployee.Name}");

        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Employee: {Name}, Age: {Age}";
        }
    }
}