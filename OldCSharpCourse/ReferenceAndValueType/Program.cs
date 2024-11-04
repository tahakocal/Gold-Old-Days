using System;
using System.Data;
using System.Dynamic;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] {"Ankara", "Adana", "Afyon"};
            string[] cities2 = new string[] { "İstanbul", "Trabozn", "Rize" };

            cities2 = cities1; // cities2nin refaransı cities1in refaransına eşit oluyor
            cities1[0] = "Koceeli";
            Console.WriteLine(cities2[0]);

            DataTable dataTable;  //newlemek çok masraflı o yüzden newlemeye burada gerek yok
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
