using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar = new int[] {1,2,3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar = sayilar2;
            sayilar2[0]=999;
            Console.WriteLine(sayilar[0]);

        }
    }
}
