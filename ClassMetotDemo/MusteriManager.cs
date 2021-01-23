using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(string name, string surname, int Id, string AccountType, string MomSurname)
        {
            Console.WriteLine("Added to box :"+ name);
        }

        public void Delete(Musteri customer)
        {
            Console.WriteLine("Deleted from box : " + customer.Name);

        }

        public void List(Musteri customer)
        {
            Console.WriteLine("Listed :");
            Console.WriteLine(customer.Name);
        }


    }
}
