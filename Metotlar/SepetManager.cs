using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle( Urun urun)
        {
            Console.WriteLine("Sepete Eklendi"+urun.Adi);
            
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat, int stokAdedi)
        {
            Console.WriteLine("Ürün Eklendi" + urunAdi);
        }

    }
}
