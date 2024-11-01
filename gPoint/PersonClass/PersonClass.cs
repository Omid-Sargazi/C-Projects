using System;

namespace PersonClasss
{
    public class PersonClass
{
    // Properties for person's details
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    // Constructor with input validation
    public PersonClass(string firstName, string lastName, int age)
    {
        SetDetails(firstName, lastName, age);
    }

    // Method to set or update details with validation
    public void SetDetails(string firstName, string lastName, int age)
    {
        // Validate first name
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException($"{nameof(FirstName)} cannot be null or empty.", nameof(firstName));
        }

        // Validate last name
        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException($"{nameof(LastName)} cannot be null or empty.", nameof(lastName));
        }

        // Validate age
        if (age < 0 || age > 120)
        {
            throw new ArgumentOutOfRangeException(nameof(age), $"{nameof(Age)} must be between 0 and 120.");
        }

        // If validations pass, set the properties
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Method to log details of the person (for demonstration)
    public void LogDetails()
    {
        Console.WriteLine($"Logging details: {nameof(FirstName)} = {FirstName}, {nameof(LastName)} = {LastName}, {nameof(Age)} = {Age}");
    }

    // Override ToString to display person's details
    public override string ToString()
    {
        return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Age)}: {Age}";
    }
}

 }