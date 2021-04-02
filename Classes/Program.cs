using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args) //işlemleri gruplara ayırmak için kullanıyoruz
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Mehmet Taha";
            customer.LastName = "Koçal";
            customer.Id = 1;

            Customer customer2 = new Customer
            {
                Id = 2, 
                LastName = "Koçal",
                City = "İstanbul",
                FirstName = "Mehmet Taha"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        } 
    }
}



