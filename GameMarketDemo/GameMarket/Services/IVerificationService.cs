using GameMarket.Entities;

namespace GameMarket.Services
{
    public interface IVerificationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
