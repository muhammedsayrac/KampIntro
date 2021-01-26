using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                GercekMusteri musteri1 = new GercekMusteri();

                musteri1.Id = 1;
                musteri1.MusteriNo = "123654";
                musteri1.Adi = "Engin";
                musteri1.Soyadi = "Demir";
                musteri1.TcNo "123456789";

                //  Kodlama io

                TuzelMusteri musteri2 = new TuzelMusteri();

                musteri2.Id = 2;
                musteri2.MusteriNo = "5624";
                musteri2.SirketAdi = "kodlama.io";
                musteri2.VergiNo = "123456789";

                Musteri musteri3 = new GercekMusteri();
                Musteri musteri4 = new TuzelMusteri();

                CustomerManager musteriManager = new CustomerManager();
                musteriManager.Add(musteri1);
                musteriManager.Add(musteri2);


            }
        }
    }
}
