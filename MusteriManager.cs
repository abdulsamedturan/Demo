using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class MusteriManager
    {
        MyList<Musteri> customers = new MyList<Musteri>();
        public void Add(Musteri musteri)
        {
            customers.Add(musteri);
        }
        public void CustomerList()
        {
            foreach (var customer in customers.Items)
            {
                Console.WriteLine("Customer name : "+ customer.Name);
                Console.WriteLine("Customer last name : "+customer.LastName);
                Console.WriteLine("Custumer id : "+customer.Id);
                Console.WriteLine("--------------------------------------");
            }
        }
        public void Delete()
        {
            customers.Delete();
        }



    }
    
}
