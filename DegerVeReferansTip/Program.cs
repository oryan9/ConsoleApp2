using System;

namespace DegerVeReferansTip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int sayi1 = 10;
            int sayı2 = 30;
            sayi1 = sayı2;

            sayı2 = 65;

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };

            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            Console.WriteLine(sayılar1[0]);

            



        }
    }
}
