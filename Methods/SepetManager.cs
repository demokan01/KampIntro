using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {//Bu tip Classlar OPERASYON tutuyor demektir.

        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Adi);

        }

        //Düzensiz Yapıyı Add'deki gibi bir düzene sokarız
        //Bu Şekilde Kullanılırsa Diğer Sayfalardada Değişikliğe Gidilir Bu yüzden bu method Tercih edilmez
        public void Add2(string Adi,string Aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + Adi);
        }
    }
}
