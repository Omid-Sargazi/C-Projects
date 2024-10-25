using System;
using System.Linq; // Needed for the Reverse() method

namespace Classes
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            // Use LINQ's Reverse and convert to char array before creating a new string
            return new string(str.Reverse().ToArray());
        }
    }
}
