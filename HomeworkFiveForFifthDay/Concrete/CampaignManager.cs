using HomeworkFiveForFifthDay.Abstract;
using HomeworkFiveForFifthDay.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " başarıyla eklendi.");
        }

        public void Delete(Campaign campaign)
        {       
            Console.WriteLine(campaign.CampaignName+ " başarıyla silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " başarıyla güncellendi.");
        }
    }
}
