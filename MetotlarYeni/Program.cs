using System;

namespace MetotlarYeni
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunYeni urun1 = new UrunYeni();
            urun1.urunAdi = "Elma";
            urun1.urunAciklamasi = "Amasya elması";
            urun1.urunFiyati = 12;
            urun1.urunStokAdedi = 10;

            UrunYeni urun2 = new UrunYeni();
            urun2.urunAdi = "Karpuz";
            urun2.urunAciklamasi = "Diyarbakır karpuzu";
            urun2.urunFiyati = 80;
            urun2.urunStokAdedi = 5;
            UrunYeni[] urunlerYeni = new UrunYeni[] {urun1,urun2};

            foreach (var urun in urunlerYeni)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunFiyati);
                Console.WriteLine(urun.urunAciklamasi);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("------------Metotlar------------");

            SepetManagerYeni sepetManager = new SepetManagerYeni();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("--------------------------------");
            sepetManager.Ekle2("Elma",12,"Yeşil Elma",10);
            sepetManager.Ekle2("Armut",15,"Yeşil Armut",11);
            sepetManager.Ekle2("Karpuz",80,"Diyarbakır Karpuzu",8);
        }

    }
}
