using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string urunAdi = "elma";
            double fiyati = 15;
            string Aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] {urun1,urun2};

            //TYPE SAFE Urun classını yazarız var da yazsan olur var zaten Urun yapar onu üstüne gelince Urun yazar la :)))
            foreach (Urun urun in urunler)    //urunler dizisinden çek al in urunler yazarız  urun takma ad istediğini yaz genelde tekili verilir ürünlerse urun gibi
            {                                   // URUN DE VERİ TİPİ CLASSI YAZARIZ
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }


            Console.WriteLine("-----------Metotlar-------------");

            //instance==> class özelliği oluşturma
            //encapsulation  =>> ilişkilendirmede zorlanıyorsan  ayrı ayrı yazmayıp classlarda bir modelde yazmadır...
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);  //metot böyle çağrılır...
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut","Yeşil Armut",12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);


        }
    }
}





// dont repeat yourself   -dry- best pratice