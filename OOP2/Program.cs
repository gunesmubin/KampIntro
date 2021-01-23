using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id=1;
            musteri1.MusteriNo = "1905";
            musteri1.Adi = "Mübin";
            musteri1.Soyadi = "Güneş";
            musteri1.TCNo = "1111111111111";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1234";
            musteri2.SirketAdi = "Kodlama.IO";
            musteri2.VergiNo = "12312312";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
