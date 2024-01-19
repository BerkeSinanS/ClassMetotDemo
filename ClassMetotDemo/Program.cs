// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;
Musteri musteri1 = new Musteri();
musteri1.Name = "LeBron";
musteri1.Surname = "James";
musteri1.Age = 38;
musteri1.Gender = 'E';
musteri1.MusteriId = 1;

Musteri musteri2 = new Musteri();
musteri2.Name = "Lionel";
musteri2.Surname = "Messi";
musteri2.Age = 36;
musteri2.Gender = 'E';
musteri2.MusteriId = 2;

Musteri musteri3 = new Musteri();
musteri3.Name = "Ebrar";
musteri3.Surname = "Karakurt";
musteri3.Age = 26;
musteri3.Gender = 'K';
musteri3.MusteriId = 3;

Musteri musteri4 = new Musteri();
musteri4.Name = "Neslihan";
musteri4.Surname = "Demir";
musteri4.Age = 40;
musteri4.Gender = 'K';
musteri4.MusteriId = 4;

Musteri musteri5 = new Musteri();
musteri5.Name = "Mauro Emanuel";
musteri5.Surname = "İcardi";
musteri5.Age = 30;
musteri5.Gender = 'E';
musteri5.MusteriId = 5;

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, };


MusteriManager customer=new MusteriManager();
//customer.AddCustomers(musteri2) ;

//customer.ListCustomers(musteriler);

customer.DeleteCustomer(musteri1);


Console.ReadLine();
