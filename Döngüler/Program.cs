using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme kampı", "Programlamaya başlangıç için temel kurs","java","c#","Python" };
 
            for (int i = 0; i < kurslar.Length; i += 1)

            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("fOR BİTTŞ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sATFA SONU - FOOTER");
        }
    }
}
