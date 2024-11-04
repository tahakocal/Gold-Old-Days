using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Ahmet";
            musteri1.Surname = "Yilmaz";
            musteri1.Mail = "ahmet@gmail.com";
            musteri1.HesapBakiyesi = 1459;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Mehmet";
            musteri2.Surname = "Arsa";
            musteri2.Mail = "mehmet@gmail.com";
            musteri2.HesapBakiyesi = 4565;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Samet";
            musteri3.Surname = "Koç";
            musteri3.Mail = "samet@gmail.com";
            musteri3.HesapBakiyesi = 23455;


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
                Console.WriteLine(musteri.Mail);
                Console.WriteLine(musteri.HesapBakiyesi);
            }

            Console.WriteLine("---------------------------------------------------");
             
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.List(musteri1);
            musteriManager.Delete(musteri1);

            Console.ReadLine();
        }
    }
}
