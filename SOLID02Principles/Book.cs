using System;

namespace MyNamespace
{
    public class Book
    {
        public string Title {get;set;}
        public string Author {get;set;}
    public void DidplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
    }

}