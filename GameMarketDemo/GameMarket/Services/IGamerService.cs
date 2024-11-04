using GameMarket.Entities;

namespace GameMarket.Services
{
    public interface IGamerService
    {
        void SignUp(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
