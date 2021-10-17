using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)

        {

            kurs kurs1 = new kurs();
            kurs1.kursAdı = "c#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdı = "java";
            kurs2.Eğitmen = "Kerem";
            kurs2.IzlenmeOranı = 64;

            kurs kurs3 = new kurs();
            kurs3.kursAdı = "Python";
            kurs3.Eğitmen = "Berkay";
            kurs3.IzlenmeOranı = 80;

            //Console.WriteLine(kurs1.kursAdı + " : " + kurs1.Eğitmen);

            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Eğitmen Adı: " + kurs.Eğitmen + " : " +  kurs.kursAdı + " Izlenme oranı ==>" + kurs.IzlenmeOranı  );
            }


        }
    }

    class kurs
    {
        public string kursAdı { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
