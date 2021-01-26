using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 3331;
            musteri1.Ad = "Canberk";
            musteri1.Soyadi = "Muzcuoğlu";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 3332;
            musteri2.Ad = "Refik";
            musteri2.Soyadi = "Günhan";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);

            musteriManager.silme(musteri1);
            musteriManager.Listeleme(musteri2);
           




        }
    }
}
