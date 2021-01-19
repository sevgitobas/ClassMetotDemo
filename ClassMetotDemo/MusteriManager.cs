using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //ekleme,listeleme,silme
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ekleniyor : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void Listeleme(params Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler listeleniyor. Lütfen bekleyin. \n");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriId + " nolu " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            }
            Console.WriteLine("Müşteriler listelendi");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Siliniyor: \n"+ musteri.MusteriId + " nolu " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " silindi.\n");
        }
    }
}
