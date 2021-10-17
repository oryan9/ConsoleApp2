using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager

    {
        // naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("you are great."   + urun.Adi +  " sepete eklendi.");


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)

        {

            Console.WriteLine("you are great." +  urunAdi  + "sepete eklendi.");

        }

    }

}
