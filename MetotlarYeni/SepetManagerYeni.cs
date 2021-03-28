using System;
using System.Collections.Generic;
using System.Text;

namespace MetotlarYeni
{
    class SepetManagerYeni
    {
        public void Ekle(UrunYeni urun)
        {
            Console.WriteLine("Tebrikler,Sepete eklendi! : "  + "\nÜrün Adı : " + urun.urunAdi + " \nFiyatı : " + urun.urunFiyati
                + " \nÜrün Açıklaması : " + urun.urunAciklamasi + "\nÜrün Stok Adedi : " + urun.urunStokAdedi);
            Console.WriteLine("--------------------------");
        }

        public void Ekle2(string urunAdi , int urunFiyati,string urunAciklamasi,int urunStokAdedi)
        {
            Console.WriteLine("Tebrikler,Sepete eklendi!" + "\nÜrün Adı : " + urunAdi + " \nFiyatı : " + urunFiyati
                + " \nÜrün Açıklaması : " + urunAciklamasi + "\nÜrün Stok Adedi : " + urunStokAdedi);
            Console.WriteLine("--------------------------");
        }

     
    }
}
