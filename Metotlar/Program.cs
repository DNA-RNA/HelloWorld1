using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyerbekir karpuzu ";
            urun1.StokAdedi = 85;
            urun2.StokAdedi = 80;
            Urun[] urunler = new Urun[] { urun1, urun2 };
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("elma", "amasya elmasi", 15);

            int sayi1 = 30;
            int sayi2 = 40;
            var sonuc = Add(ref sayi1, sayi2);
            Console.WriteLine(sonuc);
            Console.WriteLine(sayi1);

        }
        static int Add(ref int sayi1, int sayi2)
        {
            sayi1 = 35;
            return sayi1 + sayi2;
        }

    }
}
