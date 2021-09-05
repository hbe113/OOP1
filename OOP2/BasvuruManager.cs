using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager kredimanager, ILoggerService loggerService)
        {
            kredimanager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
