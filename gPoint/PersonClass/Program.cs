using System;

namespace PersonClass
{
    public class Person{
        public string FirstName{get; private set;}
        public string LastName{get; private set;}
        public int Age{get; private set;}

        public Person(string firstName, string lastName, int age)
        {
            setDetails(firstName,lastName,age);
        }

        public void setDetails(string firstName, string lastName, int age)
        {
                if(string.IsNullOrWhiteSpace(firstName)){
                    throw new ArgumentException($"{nameof(FirstName)} cannot be null or empty.", nameof(firstName));
                }

                if(string.IsNullOrWhiteSpace(lastName))
                {
                    throw new ArgumentException($"{nameof(LastName)} cannot be null or empty.", nameof(lastName));
                }

                if(age<0||age>120)
                {
                    throw new ArgumentOutOfRangeException(nameof(age), $"{nameof(Age)} must be between 0 and 120.");
                }

                FirstName = firstName;
                LastName = lastName;
                Age = age;
        }

        public void LogDetails()
    {
        Console.WriteLine($"Logging details: {nameof(FirstName)} = {FirstName}, {nameof(LastName)} = {LastName}, {nameof(Age)} = {Age}");
    }

    public override string ToString()
    {
        return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Age)}: {Age}";
    }

    }
}