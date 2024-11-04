using GameMarket.Concrete;
using GameMarket.Entities;
using System;

namespace GameMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Mehmet Taha",
                LastName = "Kocal",
                DateOfBirth = new DateTime(2002, 03, 06),
                NationalityId = "13141256235"
            };

            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FirstName = "Kemal",
                LastName = "Guler",
                DateOfBirth = new DateTime(2002, 06, 12),
                NationalityId = "1241256235"
            };

            Gamer gamer3 = new Gamer()
            {
                Id = 3,
                FirstName = "Kerim Samet",
                LastName = "Ayas",
                DateOfBirth = new DateTime(2002, 06, 17),
                NationalityId = "12341256235"
            };

            Gamer gamer4 = new Gamer()
            {
                Id = 4,
                FirstName = "Sinan",
                LastName = "Oztek",
                DateOfBirth = new DateTime(2002, 01, 12),
                NationalityId = "12341256235"
            };

            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.SignUp(gamer1);
            gamerManager.SignUp(gamer2);
            gamerManager.Update(gamer3);
            gamerManager.Delete(gamer4);

            Console.WriteLine("*******************************************************");

            Game game1 = new Game()
            {
                Id = 1,
                GameName = "GTA V",
                GamePrice = 180
            };


            Game game2 = new Game()
            {
                Id = 2,
                GameName = "Rocket League",
                GamePrice = 32
            };

            Game game3 = new Game()
            {
                Id = 3,
                GameName = "Prepar 3D V5",
                GamePrice = 1600
            };


            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game3);

            Console.WriteLine("*******************************************************");

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "KIS INDIRIMI !!!!",
                Discount = 50
            };

            Campaign campaign2 = new Campaign()
            {
                Id = 2,
                CampaignName = "YAZ INDIRIMI !!!!",
                Discount = 35
            };

            Campaign campaign3 = new Campaign()
            {
                Id = 3,
                CampaignName = "SONBAHAR INDIRIMI !!!!",
                Discount = 70
            };

            SellManager sellManager = new SellManager();
            sellManager.Sell(game1, gamer1, campaign1);
            sellManager.Sell(game2, gamer2, campaign2);
            sellManager.Sell(game3, gamer3, campaign3);




            Console.ReadLine();

        }
    }
}
