using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Web Geliştirme Kampı", "Python Kampı" };
            string[] kurslar = { "Yazılım Geliştirme Kampı","Web Geliştirme Kampı","Python Kampı" };

            Console.WriteLine();
            Console.WriteLine("****** For İle ******");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine();
            Console.WriteLine("****** ForEach İle ******");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
