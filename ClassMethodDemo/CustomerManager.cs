using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer) 
        {
            Console.WriteLine("Kayıt Başarılı :" + customer.Adi + " " + customer.Soyadi);        
        }

        public void CustomerDelete(Customer customer) 
        {
            Console.WriteLine("Kayıt Silindi :" + customer.Adi + " " + customer.Soyadi);       
        }

        public void CustomerList(Customer customer) 
        {
            
            Console.WriteLine("Müşteri Listesi :" + customer.Id + " " + customer.Adi + " " + customer.Soyadi + " " + customer.KrediNotu);
        
        }

    }
}
