using GameMarket.Entities;
using GameMarket.Services;
using System;

namespace GameMarket.Concrete
{
    public class GamerManager : IGamerService
    {
        private IVerificationService _verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }


        public void SignUp(Gamer gamer)
        {
            if (_verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " Basariyla kayit olundu");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " Bilgileriniz hatali lutfen tekrar deneyiniz!");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Sayin " + gamer.FirstName + " " + gamer.LastName + " bilgileriniz basariyla guncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Sayin " + gamer.FirstName + " " + gamer.LastName + " bilgileriniz silindi");
        }
    }
}
