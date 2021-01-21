using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani=1.45;
            bool sistemeGirisYapildimi = true;

            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            Console.WriteLine(kategoriEtiketi);

            if (sistemeGirisYapildimi==false)
            {
                Console.WriteLine("Giriş Yapılmadı");
            }
            else
            {
                Console.WriteLine("Giriş Yapıldı");
            }

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Yükseliş Ok Resmi");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Artış Ok Resmi");
            }
            else
            {
                Console.WriteLine("Yatay Seyrediyor Çizgisi");
            }
           

        }
    }
}
