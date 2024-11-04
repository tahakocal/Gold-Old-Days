using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Istanbul", 34);
            myDictionary.Add("Ankara", 06);
            myDictionary.Add("Adana", 01);

            Console.WriteLine(myDictionary.keysLength);
            Console.WriteLine(myDictionary.valuesLength);


            Console.ReadLine();
        }
    }
}
