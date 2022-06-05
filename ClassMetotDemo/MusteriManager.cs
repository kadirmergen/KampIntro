using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriID + " nolu ID'ye sahip " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " adında " + musteri.MusteriCinsiyet + " bir müşteri sisteme eklenmiştir.");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriID + " nolu ID'ye sahip " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " adında " + musteri.MusteriCinsiyet + " bir müşteri sistemden silinmiştir.");
        }
        public void MusteriListele(params Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID: " + musteri.MusteriID + " | Ad/Soyad: " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " | Cinsiyet: " + musteri.MusteriCinsiyet);
            }
        }
    }
}
