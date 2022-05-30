using System;
using System.Collections.Generic;
using System.Text;

namespace Gun3Odev3
{
    class MusteriManager
    {
        // ekle - listele- sil
        List<Musteri> musteriler = new List<Musteri>();

        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " sisteme eklendi.");
        }

        public void Listele()
        {
            Console.WriteLine("\n---- MUSTERI LISTESI ----");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Ad-Soyad: " + musteri.Ad + " " + musteri.Soyad);
                Console.WriteLine("Dogum Yili: " + musteri.DogumYili);
                Console.WriteLine("Id: " + musteri.Id);
                Console.WriteLine("Sifre: "+ musteri.Sifre);
                Console.WriteLine("Telefon Numarasi: " + musteri.TelNo);
            }
        }

        public void Sil(Musteri musteri)
        {
            // Console.WriteLine();
            Console.WriteLine("\n---------------------------------------------");
            musteriler.Remove(musteri);
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " sistemden silindi.");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
