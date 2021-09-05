using HomeworkFiveForFifthDay.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay
{
    class GamerManager:IGamerService
    {
        public void Add(Gamer gamer)
        {
            ControlManager controlManager = new ControlManager();
            controlManager.Control(gamer);
            Console.WriteLine(gamer.FirstName+ " oyuncusunun kayıt işlemi başarı ile gerçekleşti.");
            LoggerManager loggerManager = new LoggerManager();
            loggerManager.DatabaseLogger(gamer);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" oyuncusunun hesap silme işlemi başarılı bir şekilde gerçekleşti.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncusunun hesabı başarılı bir şekilde güncellendi.");
        }
    }
}
