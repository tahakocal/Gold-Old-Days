using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(25, 5);  // eğer bumber2= 30 vermezsek Add(25,35); şeklinde yapmamız gerekiyo

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2); // 20yi değiştirmek için ref kullanıp method içindeki sayıyı alabiliyoruz
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(result);
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(2, 4, 5, 5, 9, 21, 4));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int x, int number1, int number2 = 30)  // void= bir işlem yap //=30 şeklinde de verebiliyoruz
        {
            var result = number1 + number2 + x;
            return result;
        }

        static int Add3(ref int number1, int number2) // ref in diğer bir alternatifi "out"dur  // out da number1 e sayı vermek zorunda değilsin fakat ref de vermek zorundasın
        {
            number1 = 30; // out da buraya da sayıyı set etmek gerekiyor
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum(); // hocada çalışıyo ben de çalışmıyor
        }

    }
}
