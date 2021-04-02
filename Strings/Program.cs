using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args) //metinsel ifadeleri tutmak için veri tipi
        {
            //intro();

            string sentence = "My name is Mehmet Taha Koçal";
            var result= sentence.Length;  //sentence= cümle length= büyüklüğü yani kaç harf büyüklüğünde
            var result2 = sentence.Clone();
            sentence = "My name is Taha Koçal";

            bool result3 = sentence.EndsWith("ğ"); // ğ şeklinde bitiyor mu
            bool result4 = sentence.StartsWith("M"); // M ile başlıyor mu

            var result5 = sentence.IndexOf("name");  // bir şeyi bulmak için  yani name kaçıncı karakterden başlıyor . Bulamazsasa -1
            var result6 = sentence.IndexOf(" "); // boşluk arıyor ve bulduğu ilk boşluğu sayıyor
            var result7 = sentence.LastIndexOf(" "); // bu sefer sondan aramaya başlıyor
            
            var result8 = sentence.Insert(0,"Hello, "); //bir cümleye bir şey eklemeye yarıyor . 0 . noktadan itibaren hello ekledik yazıya
            var result9 = sentence.Substring(3); // 3 karakterden sonra ki bölümü alıor. 3.4 yaparsak 3. karakterden sonra 4 karakter al diyoruz
            
            var result10 = sentence.ToLower(); // bütün karakterleri küçük harfe çevirir
            var result11 = sentence.ToUpper(); // bütün karakterleri büyük harfe çevirir
            
            var result12 = sentence.Replace(" ", "-"); //boşluk yerine artık çizgi kullanıyor
            var result13 = sentence.Remove(4, 2); //4. kelimeden sonrasını silmemize yarıyor
            
            
            
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);


            Console.ReadLine();
        }

        private static void intro()
        {
            string city = "Ankara ";
            Console.WriteLine(city[0]); // 0. eleman yani sadece A harifin alıyor
            foreach (var item in city) // Alt alta yazdırdık
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul ";
            string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2)); // parantez içine result yerine yazdığımı yazabiliriz
        }
    }
}
