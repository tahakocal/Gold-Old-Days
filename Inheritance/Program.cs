using System;
using System.Reflection.Metadata.Ecma335;

namespace Inheritance  //interface kullanmak daha iyi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Taha"},
                new Students{FirstName = "Mehmet"},
                new Person {FirstName = "Ahmet"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }


        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Person2
        {
            
        }

        class Customer:Person //bir kişinin bir babası olur ama interface de yazabiliyoruz
        {
            public string City { get; set; }
        }

        class Students:Person
        {
            public string Department { get; set; }
        }


    }
}
