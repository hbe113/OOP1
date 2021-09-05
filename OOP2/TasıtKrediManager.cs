using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TasıtKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı.");
        }
    }
}
