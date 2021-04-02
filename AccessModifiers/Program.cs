using System;

namespace AccessModifiers   /// EĞER PRİVETSA SADECE KENDİ BLOKUNDA ÇALIŞIYOR PUBLİCSE HESPİNDE
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class Customer  // prive: sadece kendi blokunda// public: bütün bloklarda // 
    {               //protected: prive gibi ama tek farkı inheritance edilen classlarda da çalışıyor exp: student classında :customer da var o yüzden kullanılıyor

        private int Id { get; set; } 
        public void Save()
        {

        }

        public void Delete()
        {
           
        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            
        }
    }

    internal class Course   //internal bulunduğu klasöre paylaşabiliyor yani aynı proje içinde bu classdaki işlemleri gönderebiliyoruz
    {                       // classlar ya internal olur ya public olur
        public string Name { get; set; }
        
    }

    public class Course2
    {

    }
}
