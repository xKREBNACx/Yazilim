using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void silme (Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi."+"****"+musteri.Ad +"    "+ musteri.Soyadi+ "      " + musteri.ID);
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Listelendi." + "***" + musteri.Ad + "***" + musteri.Soyadi +"*****" + musteri.ID);
        }
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi." + musteri.Ad + "***" + musteri.Soyadi + "***" + musteri.ID);
        }
    }
}
