using System;
using System.ComponentModel.Design;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhile();
            //ForEach();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is a not a prime number");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            } 
            return result;

            Console.WriteLine();
            Console.ReadLine();

        }

        private static void ForEach()
        {
            string[] students2 = new[] {"Engin", "Derin", "Salih"};
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhile()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 5;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.Write("Now number is {0} ", number);
        }

        private static void ForLoop()
        {
            for (int i = 0;
                i <= 100;
                i += 2) //i sadece kendi blokuna ulaşabiliyor   +2 yi eksiye çevirim geriye doğru yazmasını da sağlayabiliriz
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finised!");
        }
    }
}
