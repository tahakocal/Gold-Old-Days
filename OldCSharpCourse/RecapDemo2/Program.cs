using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }

    class DatabaseLogger:ILogger                // log işi yapıyosak babası olması gerekiyo
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.Write("Logged to file");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
