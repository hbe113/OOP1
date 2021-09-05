using HomeworkFiveForFifthDay.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Concrete
{
    class ControlManager : IControlService
    {
        public void Control(Gamer gamer)
        {
            Console.WriteLine(gamer.TcNo+ " TC Numaralı "+ gamer.FirstName+" "+gamer.LastName+ " E-Devlet sistemi " +
                "üzerinden kontrol edilerek doğrulanmıştır.");
        }
    }
}
