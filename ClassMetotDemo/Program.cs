using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // yeni müşteri bilgileri
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 100;
            musteri1.MusteriAdi = "Hasan Ali";
            musteri1.MusteriSoyadi = "Kuyucu";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 101;
            musteri2.MusteriAdi = "Ender";
            musteri2.MusteriSoyadi = "Çelebi";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 102;
            musteri3.MusteriAdi = "Şahika";
            musteri3.MusteriSoyadi = "Ekinci";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 103;
            musteri4.MusteriAdi = "Yıldız";
            musteri4.MusteriSoyadi = "Yılmaz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            string selamlama = "Hoşgeldiniz\n";
            Console.WriteLine(selamlama);

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);  // müşteri ekleme fonsiyonu çalıştırılıyor
            Console.WriteLine("\n ******* \n");

            musteriManager.Listeleme(musteriler);  // müşteri listeleme fonsiyonu çalıştırılıyor
            Console.WriteLine("\n ******* \n");

            musteriManager.Silme(musteri1);   // müşteri silme fonsiyonu çalıştırılıyor
        }
    }
}
