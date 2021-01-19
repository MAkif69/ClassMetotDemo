using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri eklendi:"+ "\n" + "Adı:"+" " + musteri.Ad+ " " + " Sehri:"+ " " 
                +musteri.Sehir+ " "+"Yaşı:"+ " " +musteri.Yas);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi:" + "\n" + "Adı:" + " " + musteri.Ad + " " + " Sehri:" + " "
                + musteri.Sehir + " " + "Yaşı:" + " " + musteri.Yas);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi:" + "\n" + "Adı:" + " " + musteri.Ad + " " + " Sehri:" + " "
                + musteri.Sehir + " " + "Yaşı:" + " " + musteri.Yas);
        }
    }
}
