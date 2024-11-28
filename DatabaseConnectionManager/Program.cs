using System;

namespace DatabaseConnectionManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }


    public sealed class DatabaseConnectionManager
    {
        private static readonly Lazy<DatabaseConnectionManager> _instance = new Lazy<DatabaseConnectionManager>(() => new DatabaseConnection);

        private DatabaseConnectionManager()
        {
            Console.WriteLine("DatabaseConnectionManager instance created.");
            ConnectionString = "Server=myServer;Database=myDB;User=myUser;Password=myPass;";
        }

        public static DatabaseConnectionManager Insatnce =>_instance.Value;
    }
}