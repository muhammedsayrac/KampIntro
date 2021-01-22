using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi";

            

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            // type safe 
            foreach (Urun urun in urunler)
            {


                Console.WriteLine(urun.Adi);

                Console.WriteLine(urun.Fiyati);

                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");

            }


            Console.WriteLine("----------------------Metodlar---------------------");

            // instance - ornek
            // encapsulation
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12, 10);

            sepetManager.Ekle2("Elma", "Yesil elma", 12, 9);

            sepetManager.Ekle2("karpuz", "Diyarbakir karpuz", 12, 8);
                        
        }
    }
}


// Dont repeat yourself DRY - Clean Code - Best Practice 