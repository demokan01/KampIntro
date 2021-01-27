using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)

        {
            //Tek Değişken Tutulur
            string kurs1 = "Yazılım Geliştiri Yetiştirme Kampı";
            string kurs2 = "Programlama Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştiri Yetiştirme Kampı", "Programlama Başlangıç İçin Temel Kurs", "Java Kursu","C# Kursu"};


            // Döngü İskeleti
            
            // for Daha genel amaçlar için kullanılır
            for (int i = 0; i < kurslar.Length; i++)//1'den başlıcaz - Şart - İ'yi birer birer arttır. 
            {
                Console.WriteLine(kurslar[i]);//Kursların İ'ninci Elemanını Yazdır
            }
            Console.WriteLine("For Döngüsü Bitti");

            //foreach
            foreach (string kurs in kurslar)//var yazılsada kod çalışır . foreach dizi temelli verilere uygulanır.
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu");
        }
    }
}
