using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylist();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>(); 
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table","Tablo");
            dictionary.Add("Computer","Bilgisayar");
                          // Key      // Value
            Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key); //key de book u veriyor value de kitapbi beriyor
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("Book"));


            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); //bunu yapiyosak sadece string ile calisabiliyoruz
            cities.Add("Ankara");
            cities.Add("Istanbul");

            //Console.WriteLine(cities.Contains("Ankara")); //eger sehirlerin icersiinde ankara varsa true olur

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {Id = 1, FirstName = "Taha"});
            customers.Add(new Customer {Id = 2, FirstName = "Mehmet"});


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Abc"
            };

            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Ayse"},
                new Customer {Id = 5, FirstName = "Fatma"}
            }); //customerin icerisine ekliyoruz

            Console.WriteLine(customers.Contains(customer2));


            //customers.Clear();//listeyi temizliyor

            var index = customers.IndexOf(customer2); //veri kacinci sirada
            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2); //soruncu veri kacinci sirada
            Console.WriteLine("LastIndex : {0}", index2);

            customers.Insert(0, customer2); // kacinci siraya ne eklemek istiyosun

            customers.Remove(customer2); //buldugu ilk degeri siler digerlerini silmek icin bir daha yazariz
            customers.RemoveAll(c => c.FirstName == "Taha"); // heps'n' s'ler

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }

        private static void Arraylist()
        {
            ArrayList cities = new ArrayList(); //sayida yazabiliyoruz stringde
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("Istanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            Console.WriteLine(cities[2]); //ucuncu veriyi istanbulu yazdirdik
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }


}
