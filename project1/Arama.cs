using System;
using System.Collections.Generic;

namespace project1
{
    public static class Arama
    {
        public static int AramaYontemi()
        {
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            Console.Write("Arama yapmak istediğiniz tipi seçiniz: ");
            int secim =Convert.ToInt32(Console.ReadLine());
            return secim;
        }
        public static void IsmeGoreBul(List<Kisi> KisiListesi)
        {
            Console.Write("Aranacak isim veya soyisim girin:" );
            string isim = Console.ReadLine();

            Console.WriteLine("Arama Sonuçları");
            Console.WriteLine("*****************************");

            List<Kisi> bulunanlar = KisiListesi.FindAll(x=>x.Isim==isim || x.Soyisim==isim);
            foreach(var kisi in bulunanlar)
            {
                Console.WriteLine("İsim: "+kisi.Isim);
                Console.WriteLine("Soyisim: "+kisi.Soyisim);
                Console.WriteLine("Telefon Numarası: "+kisi.Telefon);
                Console.WriteLine("-");
            }
        }

        public static void NumarayaGoreBul(List<Kisi> KisiListesi)
        {
            Console.Write("Aranacak numarayı girin:" );
            string numara = Console.ReadLine();

            Console.WriteLine("Arama Sonuçları");
            Console.WriteLine("*****************************");

            List<Kisi> bulunanlar = KisiListesi.FindAll(x=>x.Telefon==numara);
            foreach(var kisi in bulunanlar)
            {
                Console.WriteLine("İsim: "+kisi.Isim);
                Console.WriteLine("Soyisim: "+kisi.Soyisim);
                Console.WriteLine("Telefon Numarası: "+kisi.Telefon);
                Console.WriteLine("-");
            }
        }

    }
}
