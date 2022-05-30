using System;

namespace Gun3Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri("Betül", "Şentürk", 2000, 3333333, 2233, "0222 222 2222");
            Musteri musteri2 = new Musteri("Merve", "Yavuz", 1999, 5555555, 4455, "0444 444 4444");
            Musteri musteri3 = new Musteri("Nilüfer", "Saklavcı", 2002, 7777777, 6677, "0666 666 6666");
            Musteri musteri4 = new Musteri("Ayça", "Güder", 2001, 9999999, 8899, "0888 888 8888");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele();

            musteriManager.Sil(musteri2);

            musteriManager.Listele();

            musteriManager.Sil(musteri1);

            musteriManager.Ekle(musteri4);

            musteriManager.Listele();

        }
    }
}
