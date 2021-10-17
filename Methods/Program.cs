using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 25;
            urun1.Aciklama = "Starking elamasıı";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuzz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarnakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("----------------------Methods---------");

            // instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut", "Yesşil artmut", 12,3);
            sepetManager.Ekle2("Elma", "sarı elma", 12,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır artmut", 12,4);



        }
    }
}

//Dont repeat yourself -DRY - Clean Code - Best Practice