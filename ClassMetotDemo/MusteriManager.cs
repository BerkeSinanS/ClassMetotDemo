using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
       public  void AddCustomers(Musteri customer)
        {
            Console.WriteLine("Müşteri çağrıldı: ");
            Console.WriteLine("İsim: "+ customer.Name);
            Console.WriteLine("Soyİsim: " + customer.Surname);
            Console.WriteLine("Yaş: "+ customer.Age);
            Console.WriteLine("Cinsiyet: "+customer.Gender);
            Console.WriteLine(customer.MusteriId);
            Console.WriteLine("-----------");
        }
        public void ListCustomers(Musteri[] musteriler)
        {                  
            foreach (Musteri m in musteriler)
            {
                Console.WriteLine("İsim: " + m.Name);
                Console.WriteLine("Soyİsim: " + m.Surname);
                Console.WriteLine("Yaş: " + m.Age);
                Console.WriteLine("Cinsiyet: " + m.Gender);
                Console.WriteLine(m.MusteriId);
            }
          

        }
        public void DeleteCustomer(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Name + " " + musteri.Surname);
        }
    }
}
