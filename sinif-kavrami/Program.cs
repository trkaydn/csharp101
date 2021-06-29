using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            // {
            //[Erişim belirleyici] [veri tipi] OzellikAdi;
            //[Erişim belirleyici] [geri dönüş tipi] ([parametre listesi])
            //   {
            //      //Metot Komutları 
            //   }
            // }

            //Erişim Belirleyiciler
            // * Public 
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Tarık";
            calisan1.Soyad="Aydın";
            calisan1.No=23456;
            calisan1.Departman="Satın Alma";
            calisan1.CalisanBilgileri();
            Console.WriteLine("***********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Faruk";
            calisan2.Soyad="Aydın";
            calisan2.No=12345;
            calisan2.Departman="İnsan Kaynakları";            
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Adı: "+Ad);
            Console.WriteLine("Soyadı: "+Soyad);
            Console.WriteLine("Numarası: "+No);
            Console.WriteLine("Departman: "+Departman);
        }
    }
}
