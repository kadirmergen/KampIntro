using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriAd = "Anıl";
            musteri1.MusteriSoyad = "Kara";
            musteri1.MusteriCinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriAd = "Eda";
            musteri2.MusteriSoyad = "Erdem";
            musteri2.MusteriCinsiyet = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = 3;
            musteri3.MusteriAd = "Ali";
            musteri3.MusteriSoyad = "Esenli";
            musteri3.MusteriCinsiyet = "Erkek";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriID = 4;
            musteri4.MusteriAd = "Hande";
            musteri4.MusteriSoyad = "Baladın";
            musteri4.MusteriCinsiyet = "Kadın";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            Console.WriteLine("*************************************");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("*************************************");
            musteriManager.MusteriListele(musteri1, musteri2, musteri3, musteri4);
        }
    }
}
