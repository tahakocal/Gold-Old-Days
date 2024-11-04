using GameMarket.Entities;

namespace GameMarket.Services
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
