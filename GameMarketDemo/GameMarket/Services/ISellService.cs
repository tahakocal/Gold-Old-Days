using GameMarket.Entities;

namespace GameMarket.Services
{
    public interface ISellService
    {
        void Sell(Game game, Gamer gamer, Campaign campaign);
    }
}
