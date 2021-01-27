using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not  repeat yourself - Kendini TekrarlaMA
            //kategoriEtiketi = değer tutucu - alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGiris = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            //switch (dolarBugun) 
            //{
            //    case 7.30:
            //        Console.WriteLine("Azalış Butonu");
            //        break;
            //    case 7.40:
            //        Console.WriteLine("Artış Butonu");
            //        break;
            //    default:
            //        Console.WriteLine("Değişmedi");
            //   break;
            //}




            if (sistemeGiris == true)
            {
                Console.WriteLine(" Kullanıcı ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            
            Console.ReadLine();
        }
    }
}
