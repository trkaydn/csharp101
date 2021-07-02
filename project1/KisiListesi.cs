using System;
using System.Collections.Generic;

namespace project1
{
    public static class KisiListesi
    {
        public static List<Kisi> VarsayilanKisiler()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi(){
               Isim="Tarık",
               Soyisim="Aydın",
               Telefon="05555555555"
           });
          
            kisiler.Add(new Kisi(){
               Isim="Faruk",
               Soyisim="Aydın",
               Telefon="01111111111"
           });

             kisiler.Add(new Kisi(){
               Isim="Ali",
               Soyisim="Veli",
               Telefon="09999999999"
           });

           kisiler.Add(new Kisi(){
               Isim="Ayse",
               Soyisim="Gül",
               Telefon="06666666666"
           });

             kisiler.Add(new Kisi(){
               Isim="Fatma",
               Soyisim="Tek",
               Telefon="04444444444"
           });

            return kisiler;
          
        }
     
    }
}
