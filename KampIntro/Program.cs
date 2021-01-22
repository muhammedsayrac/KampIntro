using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip guvenligi
            // do not repeat yourself

            string kategoriEtiketi = "Kategoriler";

            int ogrenciSayisi = 3200;

            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis Oku");
            }
            else
            {
                Console.WriteLine("Esittir butonu");
            }
            
           


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
            
           
        }
    }
}
