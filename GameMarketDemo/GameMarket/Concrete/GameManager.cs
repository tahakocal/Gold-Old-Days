using GameMarket.Entities;
using GameMarket.Services;
using System;

namespace GameMarket.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun sisteme eklendi: " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun sistemde guncellendi: " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun sistemden silindi: " + game.GameName);
        }
    }
}
