using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICreditManager
            PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            

            //ICreditManager
            CarCreditManager carCreditManager = new CarCreditManager();
            

            //ICreditManager
            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //interface'lerde o interface'i implemente eden class'ın referans numarasını tutabilir

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(personalFinanceCredit,databaseLoggerService);

            List<ICreditManager> krediler = new List<ICreditManager>() {personalFinanceCredit,carCreditManager};

            //basvuruManager.KrediOnBilgilendirme(krediler);
        }
    }
}
