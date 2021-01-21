using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs() {KursAdi="Yazılım Geliştirme",Egitmen="Engin Demiroğ",IzlenmeOrani=52 };
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 95;
            Kurs kurs3 = new Kurs() { KursAdi = " Python Yazılım Geliştirme", Egitmen = "Hasan Adanalı", IzlenmeOrani = 85 };

            //Console.WriteLine("Kurs Adı: {0}, Kurs Eğitmeni: {1}, İlerleme Yüzdesi: {2}",kurs1.KursAdi,kurs1.Egitmen,kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(" Kurs Adı: {0}\n Kurs Eğitmeni: {1}\n İlerleme Yüzdesi: {2}", kurs.KursAdi, kurs.Egitmen, kurs.IzlenmeOrani);
                Console.WriteLine("----------------------------");
            }
        }
    }
    public class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
