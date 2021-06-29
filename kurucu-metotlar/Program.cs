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

            Calisan calisan1 = new Calisan("Tarık","Aydın",23456,"Satın Alma");   
            calisan1.CalisanBilgileri();
            Console.WriteLine("***********");

            Calisan calisan2 = new Calisan("Faruk","Aydın",12345,"İnsan Kaynakları");           
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Tarık","Aydın");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad= ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }

        public Calisan(string ad,string soyad)
        {
            this.Ad= ad;
            this.Soyad=soyad;
        }

        public Calisan()
        {

        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Adı: "+Ad);
            Console.WriteLine("Soyadı: "+Soyad);
            Console.WriteLine("Numarası: "+No);
            Console.WriteLine("Departman: "+Departman);
        }
    }
}
