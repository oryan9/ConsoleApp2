using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            // type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }









        }
    }
}
