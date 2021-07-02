using System;
using System.Collections.Generic;

namespace project1
{
    public static class KisiSil
    {
        public static Kisi Sil(List<Kisi> kisiListesi)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string search = Console.ReadLine();
           Kisi silinecek = kisiListesi.Find(x=>x.Isim==search || x.Soyisim==search);
            if(silinecek!=null)
            {
                return silinecek;
            }
            else 
            {
                Console.WriteLine("Bu isimde bir kişi bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için     : (2)");
                int yanit = Convert.ToInt32(Console.ReadLine());
                if (yanit==1)
                {
                    Console.WriteLine("Silme işlemi iptal edildi.");
                    return null;
                }
                else if(yanit==2)
                return KisiSil.Sil(kisiListesi);
                else 
                return null;
            }

        }

    }
}
