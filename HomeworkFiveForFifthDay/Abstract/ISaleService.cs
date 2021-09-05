using HomeworkFiveForFifthDay.Concrete;
using HomeworkFiveForFifthDay.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Abstract
{
    interface ISaleService
    {
        void Sale(Game game,Gamer gamer, Campaign campaign); 
    }
}
