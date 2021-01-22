using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Temel kurs";
            string kurs3 = "Java";

            // array

            string[] kurslar = new string[] {"Yazilim Gelistirici Yetistirme Kampi", "Temel kurs",
                "Java", "Python","c#"};

            for (int i = 0; i < kurslar.Length; i=i+1)
            {
                
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("  ");
            Console.WriteLine("For bitti");
            Console.WriteLine("  ");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("Sayfa Sonu- footer");


        }
    }
}
