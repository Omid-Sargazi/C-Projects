using System;
namespace PersonClasss
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PersonClass personClass = new PersonClass("john", "Doe",25);
            personClass.LogDetails();
            Console.WriteLine(personClass.ToString());
        }
    }
}