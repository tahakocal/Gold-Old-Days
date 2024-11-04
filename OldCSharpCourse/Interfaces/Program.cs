using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager(); //bunları hatırlamakda güçlük çektim
            manager.Add(new Customer {Id = 1, FirstName = "Taha", LastName = "Koçal", Address = "Istanbul"});

            // İKİ TÜRLÜDE OLUYOR

            Student student = new Student
            {
                Id = 1,
                FirstName = "Taha",
                LastName = "Koçal",
                Departmant = "Yazılım"
            };
            manager.Add(student);
        }

        interface IPerson  //temel nesne oluşturup ondan yürütüyoruz
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson  // IPersona tanımladığımız herşeyi burada da görebiliriz
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; } // ayrıca classa özel de prop yazararak ekleyebiliyortuz
        }

        class Student:IPerson  // en sola geliyoruz kırmızı bir ampul çıkıyor implement mising element diyoruz ve kendisi yazıyor
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person) // customer yerine IPerson veriyoruz bu sayede ayrı bir yer yapmamıza gerek kalmıyor
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
            }
        }
    }
}
