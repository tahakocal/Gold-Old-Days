using GameMarket.Entities;
using GameMarket.Services;
using System;

namespace GameMarket.Concrete
{
    public class SellManager : ISellService
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            double campaignPrice = game.GamePrice - (game.GamePrice * campaign.Discount / 100);
            Console.WriteLine(game.GameName + " oyunumuzun size ozel indirimli fiyati sadece " + campaignPrice + " TL");
        }
    }
}
