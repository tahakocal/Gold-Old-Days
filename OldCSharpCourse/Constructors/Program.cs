using System;
using System.Collections.Generic;
using System.Globalization;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Product product = new Product {Id = 1,Name = "Laptop"}; // Diğer bir kullanım
            Product product2 = new Product(2, "Laptop");// Diğer kullanım


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("product");
            
            
            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count  );
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {

        public Product()
        {
            
        }

        private int _id;
        private string _name;
        public Product(int id , string name
            )
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class BaseClass  //
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher  // static de herkes için değişmesi gerekiyorsa bunu yapabiliriz
    {
        public static int Number { get; set; }
    }

    static class Utilities  //
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }
    }

    class Manager  // bazı özellikleri static yapıp bazı özellikleri normal yapabilirz
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done!");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2!");
        }
    }
}



