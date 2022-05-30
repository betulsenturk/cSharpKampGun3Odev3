using System;
using System.Collections.Generic;
using System.Text;

namespace Gun3Odev3
{
    class Musteri
    {   
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public int Id { get; set; }
        public int Sifre { get; set; }
        public string TelNo { get; set; }

        public Musteri(string Ad, string Soyad, int DogumYili, int Id, int Sifre, string TelNo)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumYili = DogumYili;
            this.Id = Id;
            this.Sifre = Sifre;
            this.TelNo = TelNo;
        }
    }
}
