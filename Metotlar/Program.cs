using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adana Karpuzu";

            Urun[] urunler = new Urun[]{urun1,urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(" Ürün Adı: {0}",urun.Adi);
                Console.WriteLine(" Ürün Fiyatı: {0}", urun.Fiyati);
                Console.WriteLine(" Ürün Açıklaması: {0}", urun.Aciklama);
                Console.WriteLine("------------------------------------");

            }

            Console.WriteLine("-------------Metodlar----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yesil Armut",12,15);
        }
    }
}
