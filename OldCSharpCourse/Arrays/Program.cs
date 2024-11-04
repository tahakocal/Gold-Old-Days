using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)    // array aslında []  // YAZIYSA YAZI YAZIYORUZ SAYIYSA SAYI YOKSA KIZAR
        {
            //string[] students = new string[3];      /// köşeli parantezin içine isimleri direkt yazabiliriz
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //string[] students2 = new []{"Engin", "Derin", "Salih" }; // bu şekil de ede yapabiliyoruz // new[] i kaldırıp da yazabiliyoruz
           

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3];  // 5 bölge 3 şehir
            {
                {"İstanul","İzmit","Balıkesir"  },
                { "Ankara","Konya","Kırıkkale" },
                { "Antalya","Adana","Mersin" },
                { "Rize","Trabzon","Samsun" },
                { "İzmir" , "Muğla" ,"Manisa" },
            };

            for (int i =0; i<= regions.GetUpperBound(0); i++)
            {
                for (int j= 0; j<= regions.GetUpperBound(); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
