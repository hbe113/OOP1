using HomeworkFiveForFifthDay.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Entities
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int CampaignDiscount { get; set; }

    }
}
