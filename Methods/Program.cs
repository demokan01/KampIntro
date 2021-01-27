using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya Elması";

            string[] meyveler = new string[] { };


            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Adana Karpuzu";

            Product[] products = new Product[] { product1,product2};


            
            foreach (var product in products) //in products(products dizisinin elamanlarını tek tek gez.(product) takma isim.(Product) çalışılacak veri tipi.
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------Methods----------");

            //instance - örnek

            //Encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12,100);
            sepetManager.Add2("Elma", "Yeşil Elma", 12,150);
            sepetManager.Add2("Karpuzt", "Adana Karpuzu", 12,200);



        }
    }
}

//Do not repeat yourself - DRY - Clean Code