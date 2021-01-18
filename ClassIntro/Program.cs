using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ali";
            int yas = 24;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Dermiroğ";
            kurs1.İzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Python";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.İzlenmeOrani = 100;
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]  // içinde kurs nesnesini tanımlayan bir array tanımladık !!! string değil kurs yazarsak her bilgiyi tutarz string olsa intler çalışmaz!!!
            {
                kurs1,kurs2,kurs3,kurs4
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }


            Ögrenci ögrenci = new Ögrenci();
            ögrenci.ad = "ali";
            ögrenci.soyad = "ağca";
            ögrenci.numara = 49;

            Ögrenci[] ögrenciler = new Ögrenci[]
            {
                ögrenci
            };


            foreach (var ögrenci1 in ögrenciler)
            {
                Console.WriteLine(ögrenci1.ad);
            }

        }

        
           
        
    }
    
    
   

    class Ögrenci
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int numara { get; set; }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }


    }
}
