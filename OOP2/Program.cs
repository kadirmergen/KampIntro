using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kadir";
            musteri1.Soyadi = "Mergen";
            musteri1.TcNo = "123455566";

            //Kodlama.io

            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "4353665353";

            //Gerçek müşteri - Tüzel Müşteri //Individual Customer - Coorprate Customer
            //SOLID

            Musteri musteri3=new GercekMusteri();
            Musteri musteri4=new TuzelMusteri();

            CustomerManager customerManager1=new CustomerManager();
            customerManager1.Add(musteri1);
            customerManager1.Add(musteri2);


        }
    }
}
