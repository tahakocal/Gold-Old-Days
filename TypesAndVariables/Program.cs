using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            char character = 'A';                   // CHAR = karakter 
            bool condition = true;                  // ya true olur ya false
            byte number1 = 0;                       // 0 ile 255 arasında
            short number2 = -32768;                 //--16bitlik yer kaplıyor
            int number3 = 10;                       // sınır 2.147.483.648 , --32 bit yer kaplıyor
            long number4 = 546498465464621;         // 9.223.372.036.854.775.808 19 karakter sayı limiti , --64 bit yer kaplıyor
            double number5 = 10.4;                  // ondalıklı sayıları yazabiliyoruz , virgülden sonra 15 16 karakter --64 bit 
            decimal number6 = 10.6m;                // virgülden sonra 28-29 tane değer tutabiliyopr
            Console.WriteLine("Number1 is {0}", number1);       //{0} virgülden sonraki değeri yazıyor
            Console.WriteLine("Number1 is {0}", number2);
            Console.WriteLine("Number1 is {0}", number3);
            Console.WriteLine("Number1 is {0}", number4);
            Console.WriteLine("Charcter is {0}", character);    //(int)character dersek eğer harflerin sayı değerini veirr
            Console.WriteLine("Number1 is {0}", number5);
            Console.WriteLine("Number1 is {0}", number6);
            Console.WriteLine((int)Days.Friday);                // int yazarsak sayısal değerini alıyor
            Console.ReadLine();

        }
    }

    enum Days
    {
        Monday=35,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday        //monday=10 şeklinde değer verebiliyoruz diğerleri verdiğimiz değerderden artarak gidiyor
    }
}