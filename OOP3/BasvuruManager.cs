using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirme(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
