using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer musteri1 = new IndividualCustomer();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            CorporateCustomer musteri2 = new CorporateCustomer();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54123";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "4518787454549";

            Customer musteri3 = new IndividualCustomer();
            Customer musteri4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            
           

            //Gerçek - Tüzel bu nesneler birbirlerine benziyorlar diye birbirleri yerine kullanılamazlar.
            //SOLID
        }
    }
}
