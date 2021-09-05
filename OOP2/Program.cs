using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasıtkredimanager = new TasıtKrediManager();
            IKrediManager ihtiyackredimanager = new İhtiyacKrediManager();

            ILoggerService databaseloggerservice = new DatabaseLoggerService();
            ILoggerService fileloggerservice = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(tasıtkredimanager, databaseloggerservice);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyackredimanager,tasıtkredimanager };

            //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
