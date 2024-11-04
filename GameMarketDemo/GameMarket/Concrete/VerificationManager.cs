using GameMarket.Entities;
using GameMarket.Services;

namespace GameMarket.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
