using System;
using System.Collections.Generic;

namespace project1
{
    public static class KisiGuncelle
    {
        public static Kisi Guncelle(List<Kisi> kisiListesi)
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string search = Console.ReadLine();
           Kisi guncellenecek = kisiListesi.Find(x=>x.Isim==search || x.Soyisim==search);
            if(guncellenecek!=null)
            {
                Console.WriteLine("Güncellenecek kişi: " + guncellenecek.Isim + " " + guncellenecek.Soyisim);
                return guncellenecek;
            }
            else 
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");
                int yanit = Convert.ToInt32(Console.ReadLine());
                if (yanit==1)
                {
                    Console.WriteLine("Güncelleme iptal edildi.");
                    return null;
                }
                else if(yanit==2)
                return KisiGuncelle.Guncelle(kisiListesi);
                else 
                return null;
            }

        }

    }
}
