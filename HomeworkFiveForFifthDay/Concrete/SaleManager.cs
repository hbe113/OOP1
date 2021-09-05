using HomeworkFiveForFifthDay.Abstract;
using HomeworkFiveForFifthDay.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            double saleprice = game.GamePrice*(100-campaign.CampaignDiscount)/100;
            Console.WriteLine(gamer.FirstName + " oyuncusu, "+game.GameName+" oyununu "+campaign.CampaignName
                + " kampanyası ile %"+campaign.CampaignDiscount+" indirimli olarak "+game.GamePrice+" TL yerine "
                + saleprice+ " TL'ye satın aldı.");
        }
    }
}
