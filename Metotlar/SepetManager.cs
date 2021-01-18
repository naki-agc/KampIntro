using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention 
        //syntax         parantez içi parametresidir!!!...............
        public void Ekle(Urun urun)    
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " +urun.Adi);
            
        }

        public void Ekle2(string UrunAdi,string Aciklama,double fiyat,int stokAdeti)  //sektörde böyle kullanıılıyor ama hatalı kullanım!!!.............
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " +UrunAdi);
        }
       
    }
}
