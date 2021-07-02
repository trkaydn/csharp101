using System;
using System.Collections.Generic;

namespace project1
{
    public static class KisiListele
    {
        public static void Listele(List<Kisi> KisiListesi)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*****************************");

            foreach(var kisi in KisiListesi)
            {
                Console.WriteLine("İsim: "+kisi.Isim);
                Console.WriteLine("Soyisim: "+kisi.Soyisim);
                Console.WriteLine("Telefon Numarası: "+kisi.Telefon);
                Console.WriteLine("-");
            }
        }

    }
}
