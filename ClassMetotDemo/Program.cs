using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "M.Akif";
            musteri1.Sehir = "Bayburt";
            musteri1.Yas = 25;

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Ekle metodu çalışır \n");
            musteriManager.Ekle(musteri1);

            Console.WriteLine("Sil metodu çalışır \n");
            musteriManager.Sil(musteri1);

            Console.WriteLine("Listele metodu çalışır \n");
            musteriManager.Listele(musteri1);

            
        }
    }
}
