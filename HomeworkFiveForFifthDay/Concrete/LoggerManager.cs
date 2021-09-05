using HomeworkFiveForFifthDay.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Concrete
{
    class LoggerManager : ILoggerService
    {
        public void DatabaseLogger(Gamer gamer)
        {
            Console.WriteLine("Database Log Message: "+gamer.FirstName+" isimli, "+gamer.TcNo+" TC numaralı oyuncunun kontrolleri" +
                " yapıldıktan sonra üyeliği onaylanmıştır.");
        }
    }
}
