using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" // " + musteri.Name + " // " + musteri.Surname + " // " + musteri.Mail + " // " + musteri.HesapBakiyesi+ "       Musteri Eklendi !!!");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " // " + musteri.Name + " // " + musteri.Surname + " // " + musteri.Mail + " // " + musteri.HesapBakiyesi + "     Musteri Listelendi !!!");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " // " + musteri.Name + " // " + musteri.Surname + " // " + musteri.Mail + " // " + musteri.HesapBakiyesi + "     Musteri Silindi !!!");
        }
    }

}
