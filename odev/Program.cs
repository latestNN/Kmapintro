using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            msuteri musteri1 = new msuteri();
            musteri1.ad = "İsmail";
            musteri1.soyad = "Yılmaz";
            musteri1.id = 5;
            musteri1.bakiye = 2000;

            msuteri musteri2 = new msuteri();
            musteri2.ad = "Mahmut";
            musteri2.soyad = "Kaya";
            musteri2.id = 10;
            musteri2.bakiye = 10000;

            msuteri[] musteriler = new msuteri[] { musteri1, musteri2 };

            foreach (var numara in musteriler)
            {
                Console.WriteLine("Müşteri ismi: " + numara.ad + "\n" + "Müşteri soyismi: " + numara.soyad + "\n" + "Müşteri id: " + numara.id + "\n" + "Müşteri bakiyesi: " + numara.bakiye);
                Console.WriteLine("---------------------");
            }








        }
    }
}
