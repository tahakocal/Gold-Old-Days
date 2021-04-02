using System;

namespace Conditionals  // CTRL+K K BIRAK CTRL+D kodu düzenliyor // CTRL+K K BIRAK CTRL+C KODU KAPATIYOR GERİ ALMAK İÇİN CTRL+K CTRL+U
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 45;
            if (number == 10)  // == ise demek "number ise "
            {
                Console.WriteLine("Number is 10");        // Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");  // bu da yazmak için diğer bir yöntem 
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }

            else // bir önce ki kodda ki şart sağlanmıyorsa else kullanıyoruz.
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            /// SWİTCH BLOKLARI İLE ÇALIŞMA
            switch (number) // bu da if yerine kullanılabilecek bir method
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)  // && ve || veya
            {
                Console.WriteLine("number is not between 0-200");
            }

            if (number < 100) //iç içe açabiliyoruz
            {
                if (number >= 90 && number < 95)
                {

                }
            }

            Console.ReadLine();
        }
    }
}
