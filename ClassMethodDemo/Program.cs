using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0956;
            customer1.Adi = "Sinem";
            customer1.Soyadi = "Ay";
            customer1.KrediNotu = "C";

            Customer customer2 = new Customer();
            customer2.Id = 0568;
            customer2.Adi = "Beren";
            customer2.Soyadi = "Venüs";
            customer2.KrediNotu = "A";

            Customer customer3 = new Customer();
            customer3.Id = 0486;
            customer3.Adi = "Fatih";
            customer3.Soyadi = "Mars";
            customer3.KrediNotu = "B";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            Console.WriteLine("MÜŞTERİ LİSTESİ");

            foreach (var custom in customers)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Müşteri Id : " + custom.Id);
                Console.WriteLine("Adı : " + custom.Adi);
                Console.WriteLine("Soyadı : " + custom.Soyadi);
                Console.WriteLine("Kredi Notu : " + custom.KrediNotu);

            }

            Console.WriteLine("---------------------------");

            CustomerManager customer = new CustomerManager();
            customer.CustomerAdd(customer1);
            customer.CustomerAdd(customer2);
            customer.CustomerAdd(customer3);

            Console.WriteLine("---------------------------");

            customer.CustomerDelete(customer1);
            customer.CustomerDelete(customer2);
            customer.CustomerDelete(customer3);

            Console.WriteLine("-----------------------------");

           

            










        }
    }
}
