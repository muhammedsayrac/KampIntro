using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.Id= 1;
            customer1.Name = "Ali";
            customer1.Surname = "Veli";
            customer1.AccountType = " Investment";
            customer1.MomSurname = "A";

            Musteri customer2 = new Musteri();
            customer2.Id = 1;
            customer2.Name = "ayse";
            customer2.Surname = "fatma";
            customer2.AccountType = " Investment";
            customer2.MomSurname = "A";

            Musteri[] customers = new Musteri[] { customer1, customer2 };

            foreach (Musteri item in customers)
            {
                
            }

            MusteriManager customerManager = new MusteriManager();
            customerManager.Add("kemal", "haci", 3, "student", "C");
            Console.WriteLine("***************************");
            customerManager.Delete(customer2);
            Console.WriteLine("***********************");
            customerManager.List(customer1);






        }
    }
}
