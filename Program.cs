using System;
using System.Collections.Generic;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri customer = new Musteri();
            customer.Name = "Abdulsamed";
            customer.Id = 1;
            customer.LastName = "turan";
            
            Musteri customer1 = new Musteri();
            customer1.Name = "busra";
            customer1.Id = 2;
            customer1.LastName = "turan";
            
            Musteri customer2 = new Musteri();
            customer2.Name = "masal";
            customer2.Id = 3;
            customer2.LastName = "turan";
           
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------FULL LİST-------");
            musteriManager.Add(customer);
            musteriManager.Add(customer1);
            musteriManager.Add(customer2);
            musteriManager.CustomerList();
            Console.WriteLine("----------UPDATE LİST----------");
            musteriManager.Delete();
            musteriManager.CustomerList();
            Console.WriteLine("----------UPDATE LİST----------");
            musteriManager.Delete();
            musteriManager.CustomerList();
        }
    }
}
