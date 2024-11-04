using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            

            Find();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                //throw;   eger hata varsa o hatayi sil direkt
            }
            

            //Method
            HandleException(() =>
            {
                Find();
            });  //kodun karsiligi //parametresiz bir kod blogu yooluyorum o kod blogunun karsiligi centik parantezin icindeki kod

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();  // findi buraya yolladik
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> {"Engin", "Derin", "Taha"};

            if (!students.Contains("Engin"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }


        private static void ExceptionIntro()
        {
            try // kodu deneiyoruz eger hatali calisiyorsa exception yazdiririyor
            {
                string[] student = new string[3] {"Taha", "Ahmet", "Yesil"};
                student[3] = "Engin";
            }
            catch (IndexOutOfRangeException exception) // eger hata buysa bu hata ıle ılgılı yaz<ıyor
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("EXCEPTIONNNNNNN!");
            }
        }
    }
}
