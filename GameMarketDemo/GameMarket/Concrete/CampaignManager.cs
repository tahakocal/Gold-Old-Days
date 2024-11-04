using GameMarket.Entities;
using GameMarket.Services;
using System;

namespace GameMarket.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanyasi basariyla eklendi!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanyasi basariyla guncellendi!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanyasi basariyla silindi!");
        }
    }
}
